
using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.builder;
using SystemMonitorServer.src.computer;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.util;

namespace SystemMonitorServer.src.service
{
    class GpuInfoService : HardwareService
    {
        private GpuInfoBuilder builder;

        public GpuInfoService() : base()
        {
        }

        public GpuInfoService(Computer computer) : base(computer)
        {
        }

        protected override void InitBuilder()
        {
            builder = new GpuInfoBuilder();
        }

        public GpuInfo GetGpuInfo()
        {
            var gpu = GetGpu(computer.Hardware);
            return builder.Build(gpu);
        }

        private IHardware GetGpu(IHardware[] hardwares)
        {
            IHardware gpu = HardwareInfoUtils.GetHardwareByType(hardwares, HardwareType.GpuNvidia);
            if (gpu == null)
            {
                gpu = HardwareInfoUtils.GetHardwareByType(hardwares, HardwareType.GpuAti);
            }
            return gpu;
        }
    }
}
