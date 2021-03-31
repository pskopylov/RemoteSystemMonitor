using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.Builder;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Util;

namespace RemoteSystemMonitor.Src.Service
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
            return motherBoard != null ? builder.Build(motherBoard) : null;
        }
    }
}
