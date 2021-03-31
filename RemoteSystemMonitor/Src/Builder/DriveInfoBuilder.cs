using OpenHardwareMonitor.Hardware;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Management;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Builder.Sensor;

namespace RemoteSystemMonitor.Src.Builder
{
    class DriveInfoBuilder
    {

        private const string ModelProperty = "Model";
        private const string DriveNameProperty = "Name";
        private const string SizeProperty = "Size";
        private const string FreeSpaceProperty = "FreeSpace";
        private const string MainQuery = "select * from Win32_DiskDrive";

        public IEnumerable<DriveDiskInfo> Build(IEnumerable<IHardware> disks)
        {
            return BuildDisksInfo(disks);
        }

        public DriveDiskInfo Build(IEnumerable<IHardware> disks, string name)
        {
            return BuildDisksInfo(disks, name);
        }

        private IEnumerable<DriveDiskInfo> BuildDisksInfo(IEnumerable<IHardware> disks)
        {
            return BuildDisksInfoByQuery(disks, MainQuery);
        }

        private DriveDiskInfo BuildDisksInfo(IEnumerable<IHardware> disks, string name)
        {
            // Always gets one drive
            return BuildDisksInfoByQuery(disks, MainQuery + $" where Model = '{name}'")[0];
        }

        private IList<DriveDiskInfo> BuildDisksInfoByQuery(IEnumerable<IHardware> disksInfo, String query)
        {
            var driveList = new List<DriveDiskInfo>();
            var driveQuery = new ManagementObjectSearcher(query);
            foreach (ManagementObject d in driveQuery.Get())
            {
                var partitionQueryText = $"associators of {{{d.Path.RelativePath}}} where AssocClass = Win32_DiskDriveToDiskPartition";
                var partitionQuery = new ManagementObjectSearcher(partitionQueryText);
                foreach (ManagementObject p in partitionQuery.Get())
                {
                    var logicalDriveQueryText = $"associators of {{{p.Path.RelativePath}}} where AssocClass = Win32_LogicalDiskToPartition";
                    var logicalDriveQuery = new ManagementObjectSearcher(logicalDriveQueryText);
                    foreach (ManagementObject ld in logicalDriveQuery.Get())
                    {
                        var diskModel = Convert.ToString(d.Properties[ModelProperty].Value);
                        var driveName = Convert.ToString(ld.Properties[DriveNameProperty].Value);
                        var totalSpace = Convert.ToUInt64(ld.Properties[SizeProperty].Value);
                        var freeSpace = Convert.ToUInt64(ld.Properties[FreeSpaceProperty].Value);

                        driveList.Add(CreateDiskInfo(diskModel, driveName, totalSpace, freeSpace));
                    }
                }
            }
            UpdateTemperatureInfo(disksInfo, driveList);
            return driveList;
        }

        private DriveDiskInfo CreateDiskInfo(String diskModel, String driveName, ulong totalSpace, ulong freeSpace)
        {
            return new DriveDiskInfo()
            {
                Name = diskModel,
                DriveName = driveName,
                TotalSpace = totalSpace,
                FreeSpace = freeSpace
            };
        }

        private void UpdateTemperatureInfo(IEnumerable<IHardware> diskInfos, IList<DriveDiskInfo> driveList)
        {
            foreach (var drive in driveList)
            {
                IHardware hardwareDisk = diskInfos.Where(disk => disk.Name.Equals(drive.Name)).FirstOrDefault();
                if (hardwareDisk != null)
                {
                    var sensors = new DriveSensors(hardwareDisk.Sensors);
                    drive.Temperature = sensors.Temperature;
                }
            }
        }


    }
}
