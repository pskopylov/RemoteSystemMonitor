using OpenHardwareMonitor.Hardware;

namespace RemoteHardwareMonitor.Src.Builder.Sensor
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
