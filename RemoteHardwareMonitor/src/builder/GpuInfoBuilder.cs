using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Builder.Sensor;

namespace RemoteHardwareMonitor.Src.Builder
{
    class GpuInfoBuilder
    {

        public GpuInfo Build(IHardware gpu)
        {
            GpuSensors sensors = new GpuSensors(gpu.Sensors);
            return new GpuInfo()
            {
                Name = gpu.Name,
                CoreTemperature = sensors.CoreTemperature,
                CoreClock = sensors.CoreClock,
                CoreLoad = sensors.CoreLoad,
                MemoryLoad = sensors.MemoryLoad,
                MemoryClock = sensors.MemoryClock,
                MemoryTotal = sensors.MemoryTotal,
                MemoryUsed = sensors.MemoryUsed,
                MemoryFree = sensors.MemoryFree,
                FanInfo = new FanInfo()
                {
                    Rpm = sensors.FanRpm,
                    Load = sensors.FanLoad
                }
            };
        } 

    }
}
