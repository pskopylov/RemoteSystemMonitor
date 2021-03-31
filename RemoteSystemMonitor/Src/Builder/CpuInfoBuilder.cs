using OpenHardwareMonitor.Hardware;
using System;
using RemoteSystemMonitor.Src.Model;
using System.Management;
using System.Linq;
using RemoteSystemMonitor.Src.Builder.Sensor;
using OpenHardwareMonitor.Hardware.CPU;

namespace RemoteSystemMonitor.Src.Builder
{
    class CpuInfoBuilder
    {

        public CpuInfo Build(GenericCPU cpu)
        {
            var sensors = new CpuSensors(cpu.Sensors);
            return new CpuInfo
            {
                Name = cpu.Name,
                PhysicalCores = cpu.GetCoreCount(),
                LogicalCores = GetLogicalCores(),
                Clock = cpu.TimeStampCounterFrequency,
                TotalLoad = sensors.TotalLoad,
                CoreLoads = sensors.GetCoreLoads(),
                CoreClocks = sensors.GetCoreClocks(),
                Temperature = sensors.Temperature
            };
        }

        public CpuInfo BuildOnlySensors(GenericCPU cpu)
        {
            var sensors = new CpuSensors(cpu.Sensors);
            return new CpuInfo
            {
                Name = cpu.Name,
                Clock = cpu.TimeStampCounterFrequency,
                TotalLoad = sensors.TotalLoad,
                CoreLoads = sensors.GetCoreLoads(),
                CoreClocks = sensors.GetCoreClocks(),
                Temperature = sensors.Temperature
            };
        }

        private int GetLogicalCores()
        {
            return Environment.ProcessorCount;
        }

    }
}
