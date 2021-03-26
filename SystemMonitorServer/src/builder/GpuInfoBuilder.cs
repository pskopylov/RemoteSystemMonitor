using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.computer.sensor;
using SystemMonitorServer.src.model;

namespace SystemMonitorServer.src.builder
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
