using System.Web.Http;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.service;

namespace InsaneHardwareMonitor.src.controller
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
