using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.Builder;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Util;

namespace RemoteSystemMonitor.Src.Service
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
