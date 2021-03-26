using OpenHardwareMonitor.Hardware;
using InsaneHardwareMonitor.src.builder;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.util;

namespace InsaneHardwareMonitor.src.service
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
            return builder.Build(ram);
        } 

    }
}
