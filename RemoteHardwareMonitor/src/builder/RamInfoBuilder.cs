using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Builder.Sensor;

namespace RemoteHardwareMonitor.Src.Builder
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
