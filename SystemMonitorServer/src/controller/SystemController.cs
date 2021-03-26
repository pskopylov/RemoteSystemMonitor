using System.Web.Http;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.service;

namespace SystemMonitorServer.src.controller
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
