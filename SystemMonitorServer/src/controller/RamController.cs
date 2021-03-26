using System.Web.Http;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.service;

namespace SystemMonitorServer.src.controller
{
    public class RamController : ApiController
    {

        private readonly RamInfoService service = new RamInfoService();

        public RamInfo Get()
        {
            return service.GetRamInfo();
        } 

    }
}
