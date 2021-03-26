using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.builder;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.util;

namespace SystemMonitorServer.src.service
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
