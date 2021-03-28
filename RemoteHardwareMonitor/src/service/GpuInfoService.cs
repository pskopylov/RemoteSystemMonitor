
using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Builder;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Util;

namespace RemoteHardwareMonitor.Src.Service
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
            return gpu != null ? builder.Build(gpu) : null;
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
