using System.Web.Http;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Service;

namespace RemoteHardwareMonitor.Src.Сontroller
{
    public class CpuController : ApiController
    {

        private readonly CpuInfoService service = new CpuInfoService();

        // It pretty long to retrieve physical core count info, so cache it value and then call only monitor/cpu/sensors
        public CpuInfo Get()
        {
            return service.GetCpuInfo();
        }

        [ActionName("Sensors")]
        public CpuInfo GetOnlySensors()
        {
            return service.GetCpuSesnorsInfo();
        }

    }
}
