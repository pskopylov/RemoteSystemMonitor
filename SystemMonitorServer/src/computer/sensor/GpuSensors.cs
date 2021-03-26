
using OpenHardwareMonitor.Hardware;

namespace SystemMonitorServer.src.computer.sensor
{
    class GpuSensors : HardwareSensors
    {

        private const string GPU_CORE = "GPU Core";
        private const string GPU_MEMORY = "GPU Memory";
        private const string GPU_FAN = "GPU Fan";
        private const string GPU_MEMORY_TOTAL = "GPU Memory Total";
        private const string GPU_MEMORY_USED = "GPU Memory Used";
        private const string GPU_MEMORY_FREE = "GPU Memory Free";

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
                case GPU_CORE:
                    CoreClock = value;
                    break;
                case GPU_MEMORY:
                    MemoryClock = value;
                    break;
            }
        }

        private void SetLoadValue(string name, float? value)
        {
            switch (name)
            {
                case GPU_CORE:
                    CoreLoad = value;
                    break;
                case GPU_MEMORY:
                    MemoryLoad = value;
                    break;
                case GPU_FAN:
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
                case GPU_MEMORY_TOTAL:
                    MemoryTotal = value;
                    break;
                case GPU_MEMORY_USED:
                    MemoryUsed = value;
                    break;
                case GPU_MEMORY_FREE:
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
