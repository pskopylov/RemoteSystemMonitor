using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.Builder;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Util;
using System.Collections.Generic;

namespace RemoteSystemMonitor.Src.Service
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
