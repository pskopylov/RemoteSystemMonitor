using OpenHardwareMonitor.Hardware;
using InsaneHardwareMonitor.src.builder;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.util;

namespace InsaneHardwareMonitor.src.service
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
