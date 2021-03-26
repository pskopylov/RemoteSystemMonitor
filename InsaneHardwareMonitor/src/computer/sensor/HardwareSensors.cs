using OpenHardwareMonitor.Hardware;

namespace InsaneHardwareMonitor.src.computer.sensor
{
    abstract class HardwareSensors
    {

        protected HardwareSensors(ISensor[] sensors)
        {
            RetrieveSensors(sensors);
        }

        protected abstract void RetrieveSensors(ISensor[] sensors);
    }
}
