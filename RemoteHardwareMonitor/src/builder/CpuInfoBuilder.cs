using OpenHardwareMonitor.Hardware;
using System;
using RemoteHardwareMonitor.Src.Model;
using System.Management;
using System.Linq;
using RemoteHardwareMonitor.Src.Builder.Sensor;

namespace RemoteHardwareMonitor.Src.Builder
{
    class CpuInfoBuilder
    {

        private const string SEARCH_QUERY = "Select * from Win32_Processor";
        private const string NUMBER_OF_CORES = "NumberOfCores";

        public CpuInfo Build(IHardware cpu)
        {
            var sensors = new CpuSensors(cpu.Sensors);
            return new CpuInfo
            {
                Name = cpu.Name,
                PhysicalCores = GetPhysicalCores(),
                LogicalCores = GetLogicalCores(),
                TotalLoad = sensors.TotalLoad,
                CoreLoads = sensors.GetCoreLoads(),
                CoreClocks = sensors.GetCoreClocks(),
                Temperature = sensors.Temperature
            };
        }

        public CpuInfo BuildOnlySensors(IHardware cpu)
        {
            var sensors = new CpuSensors(cpu.Sensors);
            return new CpuInfo
            {
                Name = cpu.Name,
                TotalLoad = sensors.TotalLoad,
                CoreLoads = sensors.GetCoreLoads(),
                CoreClocks = sensors.GetCoreClocks(),
                Temperature = sensors.Temperature
            };
        }

        private int GetPhysicalCores()
        {
            var searcher = new ManagementObjectSearcher(SEARCH_QUERY);
            return searcher.Get().OfType<ManagementBaseObject>().Sum(item => int.Parse(item[NUMBER_OF_CORES].ToString()));
        }

        private int GetLogicalCores()
        {
            return Environment.ProcessorCount;
        }

    }
}
