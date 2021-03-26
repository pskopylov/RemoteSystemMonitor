using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.computer.sensor;
using SystemMonitorServer.src.model;

namespace SystemMonitorServer.src.builder
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
