using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.builder;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.util;

namespace SystemMonitorServer.src.service
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
            var cpu = HardwareInfoUtils.GetHardwareByType(computer.Hardware, HardwareType.CPU);
            return builder.Build(cpu);
        }

        public CpuInfo GetCpuSesnorsInfo()
        {
            var cpu = HardwareInfoUtils.GetHardwareByType(computer.Hardware, HardwareType.CPU);
            return builder.BuildOnlySensors(cpu);
        }

    }
}
