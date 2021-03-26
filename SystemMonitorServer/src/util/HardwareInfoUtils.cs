using OpenHardwareMonitor.Hardware;
using System.Collections.Generic;
using System.Linq;

namespace SystemMonitorServer.src.util
{
    class HardwareInfoUtils
    {

        public static IList<ISensor> GetSensorsByType(ISensor[] sensors, SensorType type)
        {
            return sensors.OfType<ISensor>().ToList().FindAll(sensor => type == sensor.SensorType);
        }

        public static IHardware GetHardwareByType(IHardware[] hardwares, HardwareType type)
        {
            return hardwares.OfType<IHardware>().ToList().Find(hardware => type == hardware.HardwareType);
        }

        public static IList<IHardware> GetHardwaresByType(IHardware[] hardwares, HardwareType type)
        {
            return hardwares.OfType<IHardware>().ToList().FindAll(hardware => type == hardware.HardwareType);
        }
    }
}
