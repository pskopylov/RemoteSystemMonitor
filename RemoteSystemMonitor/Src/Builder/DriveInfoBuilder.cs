using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Management;
using RemoteSystemMonitor.Src.Model;

namespace RemoteSystemMonitor.Src.Builder
{
    class DriveInfoBuilder
    {

        private const string MODEL_PROPERTY = "Model";
        private const string DRIVE_NAME_PROPERTY = "Name";
        private const string SIZE_PROPERTY = "Size";
        private const string FREE_SPACE_PROPERTY = "FreeSpace";
        private const string MAIN_QUERY = "select * from Win32_DiskDrive";

        public IEnumerable<DriveDiskInfo> Build(IList<IHardware> disks)
        {
            return BuildDisksInfo();
        }

        public DriveDiskInfo Build(IList<IHardware> disks, string name)
        {
            return BuildDisksInfo(name);
        }

        private IEnumerable<DriveDiskInfo> BuildDisksInfo()
        {
            return BuildDisksInfoByQuery(MAIN_QUERY);
        }

        private DriveDiskInfo BuildDisksInfo(string name)
        {
            // Always gets one drive
            return BuildDisksInfoByQuery(MAIN_QUERY + $" where Model = '{name}'")[0];
        }

        private IList<DriveDiskInfo> BuildDisksInfoByQuery(String query)
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
                        var diskModel = Convert.ToString(d.Properties[MODEL_PROPERTY].Value);
                        var driveName = Convert.ToString(ld.Properties[DRIVE_NAME_PROPERTY].Value);
                        var totalSpace = Convert.ToUInt64(ld.Properties[SIZE_PROPERTY].Value);
                        var freeSpace = Convert.ToUInt64(ld.Properties[FREE_SPACE_PROPERTY].Value);

                        driveList.Add(CreateDiskInfo(diskModel, driveName, totalSpace, freeSpace));
                    }
                }
            }
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

    }
}
