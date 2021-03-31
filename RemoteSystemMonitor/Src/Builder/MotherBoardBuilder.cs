using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Builder.Sensor;

namespace RemoteSystemMonitor.Src.Builder
{
    class MotherBoardBuilder
    {

        public MotherBoardInfo Build(IHardware motherBoard)
        {
            if (motherBoard.SubHardware.Length > 0)
            {
                var chip = motherBoard.SubHardware[0];
                var sensors = new MotherBoardSensors(chip.Sensors);
                return new MotherBoardInfo()
                {
                    Name = motherBoard.Name,
                    FanInfos = sensors.FanInfos
                };
            }
            return null;
        }

    }
}
