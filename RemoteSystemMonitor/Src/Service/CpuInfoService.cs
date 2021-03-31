using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor.Hardware.CPU;
using RemoteSystemMonitor.Src.Builder;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Util;

namespace RemoteSystemMonitor.Src.Service
{
    class CpuInfoService : HardwareService
    {
        private CpuInfoBuilder builder;

        public CpuInfoService() : base()
        {
        }

        public CpuInfoService(Computer computer) : base(computer)
        {
        }

        protected override void InitBuilder()
        {
            builder = new CpuInfoBuilder();
        }

        public CpuInfo GetCpuInfo()
        {
            var cpu = HardwareInfoUtils.GetCPU(computer.Hardware, HardwareType.CPU);
            return cpu != null ? builder.Build(cpu) : null;
        }

        public CpuInfo GetCpuSesnorsInfo()
        {
            var cpu = HardwareInfoUtils.GetCPU(computer.Hardware, HardwareType.CPU);
            return cpu != null ? builder.BuildOnlySensors(cpu) : null;
        }

    }
}
