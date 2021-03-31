using OpenHardwareMonitor.Hardware;

namespace RemoteSystemMonitor.Src.Builder.Sensor
{
    class RamSensors : HardwareSensors
    {

        private const string USED_MEMORY = "Used Memory";
        private const string AVAILABLE_MEMORY = "Available Memory";

        public float? Load { get; set; }
        public float? UsedMemory { get; set; }
        public float? AvailableMemory { get; set; }

        public RamSensors(ISensor[] sensors) : base(sensors)
        {
        }

        protected override void RetrieveSensors(ISensor[] sensors)
        {
            foreach (ISensor sensor in sensors)
            {
                switch (sensor.SensorType)
                {
                    case SensorType.Load:
                        SetLoadValue(sensor.Value);
                        break;
                    case SensorType.Data:
                        SetMemoryValue(sensor.Name, sensor.Value);
                        break;
                }
            }
        }

        private void SetLoadValue(float? value)
        {
            Load = value;
        }

        private void SetMemoryValue(string name, float? value)
        {
            switch (name)
            {
                case USED_MEMORY:
                    UsedMemory = value;
                    break;
                case AVAILABLE_MEMORY:
                    AvailableMemory = value;
                    break;
            }
        }
    }
}
