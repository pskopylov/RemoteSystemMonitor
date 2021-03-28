using OpenHardwareMonitor.Hardware;
using System.Collections.Generic;
using InsaneHardwareMonitor.src.builder;
using InsaneHardwareMonitor.src.computer;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.util;

namespace InsaneHardwareMonitor.src.service
{
    class DriveInfoService : HardwareService
    {

        private DriveInfoBuilder builder;

        public DriveInfoService() : base()
        {
        }

        public DriveInfoService(Computer computer) : base(computer)
        {
        }

        protected override void InitBuilder()
        {
            builder = new DriveInfoBuilder();
        }


        public IEnumerable<DriveDiskInfo> GetDriveInfos()
        {
            var drives = HardwareInfoUtils.GetHardwaresByType(computer.Hardware, HardwareType.HDD);
            return builder.Build(drives);
        }

        public DriveDiskInfo GetDriveInfo(string name)
        {
            var drives = HardwareInfoUtils.GetHardwaresByType(computer.Hardware, HardwareType.HDD);
            return builder.Build(drives, name);
        }

    }
}
