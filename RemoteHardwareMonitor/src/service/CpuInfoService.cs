using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Builder;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Util;

namespace RemoteHardwareMonitor.Src.Service
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
            return cpu != null ? builder.Build(cpu) : null;
        }

        public CpuInfo GetCpuSesnorsInfo()
        {
            var cpu = HardwareInfoUtils.GetHardwareByType(computer.Hardware, HardwareType.CPU);
            return cpu != null ? builder.BuildOnlySensors(cpu) : null;
        }

    }
}
