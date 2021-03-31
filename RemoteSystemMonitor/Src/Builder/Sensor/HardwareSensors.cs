using OpenHardwareMonitor.Hardware;

namespace RemoteSystemMonitor.Src.Builder.Sensor
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
