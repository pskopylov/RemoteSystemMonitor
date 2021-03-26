using OpenHardwareMonitor.Hardware;
using System.Collections.Generic;
using SystemMonitorServer.src.builder;
using SystemMonitorServer.src.computer;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.util;

namespace SystemMonitorServer.src.service
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
