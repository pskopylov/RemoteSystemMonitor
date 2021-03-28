using System.Web.Http;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.service;

namespace InsaneHardwareMonitor.src.controller
{
    public class SystemController : ApiController
    {

        private readonly SystemInfoService service = new SystemInfoService();

        public SystemInfo Get()
        {
            return service.GetSystemInfo();
        }
    }
}
