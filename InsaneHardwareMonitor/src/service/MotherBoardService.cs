using OpenHardwareMonitor.Hardware;
using InsaneHardwareMonitor.src.builder;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.util;

namespace InsaneHardwareMonitor.src.service
{
    class MotherBoardService : HardwareService
    {

        private MotherBoardBuilder builder;

        public MotherBoardService() : base()
        {
        }

        public MotherBoardService(Computer computer) : base(computer)
        {
        }

        protected override void InitBuilder()
        {
            builder = new MotherBoardBuilder();
        }

        public MotherBoardInfo GetMotherBoardInfo()
        {
            var motherBoard = HardwareInfoUtils.GetHardwareByType(computer.Hardware, HardwareType.Mainboard);
            return builder.Build(motherBoard);
        }
    }
}
