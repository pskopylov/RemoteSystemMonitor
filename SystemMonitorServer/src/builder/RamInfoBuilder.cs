using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.computer.sensor;
using SystemMonitorServer.src.model;

namespace SystemMonitorServer.src.builder
{
    class RamInfoBuilder
    {

        public RamInfo Build(IHardware ram)
        {
            var sensors = new RamSensors(ram.Sensors);
            return new RamInfo()
            {
                Name = ram.Name,
                Load = sensors.Load,
                UsedMemory = sensors.UsedMemory,
                AvailableMemory = sensors.AvailableMemory
            };
        }

    }
}
