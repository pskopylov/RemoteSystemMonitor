using System.Web.Http;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.service;

namespace SystemMonitorServer.src.controller
{
    public class GpuController : ApiController
    {

        private readonly GpuInfoService service = new GpuInfoService();

        public GpuInfo Get()
        {
            return service.GetGpuInfo();
        }

    }
}
