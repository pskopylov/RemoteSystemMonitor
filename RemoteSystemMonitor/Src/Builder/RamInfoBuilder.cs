using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Builder.Sensor;
using System.Linq;
using System.Management;
using System.Collections.Generic;

namespace RemoteSystemMonitor.Src.Builder
{
    class RamInfoBuilder
    {

        public RamInfo Build(IHardware ram)
        {
            var sensors = new RamSensors(ram.Sensors);
            return new RamInfo()
            {
                Name = GetName(),
                Load = sensors.Load,
                UsedMemory = sensors.UsedMemory,
                AvailableMemory = sensors.AvailableMemory
            };
        }

        private string GetName()
        {
            var searcher = new ManagementObjectSearcher("SELECT PartNumber FROM Win32_PhysicalMemory");
            return searcher.Get().OfType<ManagementBaseObject>()
                .Select(item => item.Properties["PartNumber"].Value.ToString())
                .FirstOrDefault();
        }

    }
}
