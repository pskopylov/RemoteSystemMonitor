using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Builder;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Util;

namespace RemoteHardwareMonitor.Src.Service
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
