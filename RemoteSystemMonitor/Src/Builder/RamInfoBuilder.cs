using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Builder.Sensor;

namespace RemoteSystemMonitor.Src.Builder
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
