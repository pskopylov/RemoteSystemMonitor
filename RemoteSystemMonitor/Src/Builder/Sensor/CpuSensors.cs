using OpenHardwareMonitor.Hardware;
using System.Collections.Generic;
using System.Linq;

namespace RemoteSystemMonitor.Src.Builder.Sensor
{
    class CpuSensors : HardwareSensors
    {
        private const string BusSpeed = "Bus Speed";
        private const string CpuTotalLoad = "CPU Total";
        private const string CpuPackage = "CPU Package";

        public float? Temperature { get; set; }
        public float? TotalLoad { get; set; }
        private readonly LinkedList<float?> CoreLoads = new LinkedList<float?>();
        private readonly LinkedList<float?> CoreClocks = new LinkedList<float?>();

        public CpuSensors(ISensor[] sensors) : base(sensors)
        {
        }

        public float?[] GetCoreLoads()
        {
            return CoreLoads.ToArray();
        }

        public float?[] GetCoreClocks()
        {
            return CoreClocks.ToArray();
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
                        SetTemperatureValue(sensor.Name, sensor.Value);
                        break;
                }
            }
        }

        private void SetClockValue(string name, float? value)
        {
            if (!BusSpeed.Equals(name))
            {
                CoreClocks.AddLast(value);
            }
        }

        private void SetLoadValue(string name, float? value)
        {
            if (CpuTotalLoad.Equals(name))
            {
                TotalLoad = value;
            } else
            {
                CoreLoads.AddLast(value);
            }
        }

        private void SetTemperatureValue(string name, float? value)
        {
            if (CpuPackage.Equals(name))
            {
                Temperature = value;
            }
        }

    }
}
