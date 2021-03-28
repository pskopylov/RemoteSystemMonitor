using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Builder.Sensor;

namespace RemoteHardwareMonitor.Src.Builder
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
