using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Builder;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Util;

namespace RemoteHardwareMonitor.Src.Service
{
    class RamInfoService : HardwareService
    {

        private RamInfoBuilder builder;

        public RamInfoService() : base()
        {
        }

        public RamInfoService(Computer computer) : base(computer)
        {
        }

        protected override void InitBuilder()
        {
            builder = new RamInfoBuilder();
        }

        public RamInfo GetRamInfo()
        {
            var ram = HardwareInfoUtils.GetHardwareByType(computer.Hardware, HardwareType.RAM);
            return ram != null ? builder.Build(ram) : null;
        } 

    }
}
