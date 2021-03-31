using OpenHardwareMonitor.Hardware;

namespace RemoteSystemMonitor.Src.Builder.Sensor
{
    class DriveSensors : HardwareSensors
    {
        public float? Temperature { get; set; }
        public float? Load { get; set; }

        public DriveSensors(ISensor[] sensors) : base(sensors)
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
                    case SensorType.Temperature:
                        SetTemperatureValue(sensor.Value);
                        break;
                }
            }
        }

        private void SetLoadValue(float? value)
        {
            Load = value;
        }

        private void SetTemperatureValue(float? value)
        {
            Temperature = value;
        }
    }
}
