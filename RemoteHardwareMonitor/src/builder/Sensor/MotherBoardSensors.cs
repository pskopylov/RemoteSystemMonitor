using OpenHardwareMonitor.Hardware;
using System.Collections.Generic;
using System.Linq;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Util;

namespace RemoteHardwareMonitor.Src.Builder.Sensor
{
    class MotherBoardSensors : HardwareSensors
    {

        public List<FanInfo> FanInfos { get; set; }

        public MotherBoardSensors(ISensor[] sensors) : base(sensors)
        {
        }

        protected override void RetrieveSensors(ISensor[] sensors)
        {
            var fans = HardwareInfoUtils.GetSensorsByType(sensors, SensorType.Fan).ToList();
            FanInfos = fans.ConvertAll(fan => CreateFanInfo(fan)).ToList();
        }

        private FanInfo CreateFanInfo(ISensor fan)
        {
            return new FanInfo()
            {
                Name = fan.Name,
                Rpm = fan.Value
            };
        }

    }
}
