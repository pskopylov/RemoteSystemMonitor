using OpenHardwareMonitor.Hardware;
using InsaneHardwareMonitor.src.computer.sensor;
using InsaneHardwareMonitor.src.model;

namespace InsaneHardwareMonitor.src.builder
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
