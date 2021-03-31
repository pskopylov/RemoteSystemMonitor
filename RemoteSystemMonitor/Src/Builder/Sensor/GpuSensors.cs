using OpenHardwareMonitor.Hardware;

namespace RemoteSystemMonitor.Src.Builder.Sensor
{
    class GpuSensors : HardwareSensors
    {

        private const string GpuCode = "GPU Core";
        private const string GpuMemory = "GPU Memory";
        private const string GpuFan = "GPU Fan";
        private const string GpuMemoryTotal = "GPU Memory Total";
        private const string GpuMemoryUsed = "GPU Memory Used";
        private const string GpuMemoryFree = "GPU Memory Free";

        public float? CoreTemperature { get; set; }
        public float? CoreClock { get; set; }
        public float? CoreLoad { get; set; }
        public float? MemoryClock { get; set; }
        public float? MemoryTotal { get; set; }
        public float? MemoryUsed { get; set; }
        public float? MemoryFree { get; set; }
        public float? MemoryLoad { get; set; }
        public float? FanLoad { get; set; }
        public float? FanRpm { get; set; }

        public GpuSensors(ISensor[] sensors) : base(sensors)
        {
        }

        protected override void RetrieveSensors(ISensor[] sensors)
        {
            foreach (ISensor sensor in sensors)
            {
                switch (sensor.SensorType)
                {
                    case SensorType.Clock:
                        SetClockValue(sensor.Name, sensor.Value);
                        break;
                    case SensorType.Load:
                        SetLoadValue(sensor.Name, sensor.Value);
                        break;
                    case SensorType.Temperature:
                        SetTemperatureValue(sensor.Value);
                        break;
                    case SensorType.SmallData:
                        SetMemoryValue(sensor.Name, sensor.Value);
                        break;
                    case SensorType.Control:
                        SetFanLoadValue(sensor.Value);
                        break;
                    case SensorType.Fan:
                        SetFanRpmValue(sensor.Value);
                        break;
                }
            }
        }

        private void SetClockValue(string name, float? value)
        {
            switch (name)
            {
                case GpuCode:
                    CoreClock = value;
                    break;
                case GpuMemory:
                    MemoryClock = value;
                    break;
            }
        }

        private void SetLoadValue(string name, float? value)
        {
            switch (name)
            {
                case GpuCode:
                    CoreLoad = value;
                    break;
                case GpuMemory:
                    MemoryLoad = value;
                    break;
                case GpuFan:
                    FanLoad = value;
                    break;
            }
        }

        private void SetTemperatureValue(float? value)
        {
            CoreTemperature = value;
        }

        private void SetMemoryValue(string name, float? value)
        {
            switch (name)
            {
                case GpuMemoryTotal:
                    MemoryTotal = value;
                    break;
                case GpuMemoryUsed:
                    MemoryUsed = value;
                    break;
                case GpuMemoryFree:
                    MemoryFree = value;
                    break;
            }
        }

        private void SetFanLoadValue(float? value)
        {
            FanLoad = value;
        }

        private void SetFanRpmValue(float? value)
        {
            FanRpm = value;
        }

    }
}
