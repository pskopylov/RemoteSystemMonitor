using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor.Hardware.CPU;
using System.Collections.Generic;
using System.Linq;

namespace RemoteSystemMonitor.Src.Util
{
    class HardwareInfoUtils
    {

        public static IEnumerable<ISensor> GetSensorsByType(ISensor[] sensors, SensorType type)
        {
            return sensors.OfType<ISensor>().Where(sensor => type == sensor.SensorType);
        }

        public static IHardware GetHardwareByType(IHardware[] hardwares, HardwareType type)
        {
            return hardwares.OfType<IHardware>().Where(hardware => type == hardware.HardwareType).FirstOrDefault();
        }

        public static IEnumerable<IHardware> GetHardwaresByType(IHardware[] hardwares, HardwareType type)
        {
            return hardwares.OfType<IHardware>().Where(hardware => type == hardware.HardwareType);
        }

        public static GenericCPU GetCPU(IHardware[] hardwares, HardwareType type)
        {
            return (GenericCPU) GetHardwareByType(hardwares, type);
        }
    }
}
