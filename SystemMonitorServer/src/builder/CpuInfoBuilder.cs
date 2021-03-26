using OpenHardwareMonitor.Hardware;
using System;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.computer.sensor;
using System.Management;

namespace SystemMonitorServer.src.builder
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
            var coreCount = 0;
            var searcher = new ManagementObjectSearcher(SEARCH_QUERY);
            foreach (var item in searcher.Get())
            {
                coreCount += int.Parse(item[NUMBER_OF_CORES].ToString());
            }
            return coreCount;
        }

        private int GetLogicalCores()
        {
            return Environment.ProcessorCount;
        }

    }
}
