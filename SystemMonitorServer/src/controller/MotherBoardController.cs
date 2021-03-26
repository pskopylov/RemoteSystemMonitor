using System.Web.Http;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.service;

namespace SystemMonitorServer.src.controller
{
    public class MotherBoardController : ApiController
    {

        private readonly MotherBoardService service = new MotherBoardService();

        public MotherBoardInfo Get()
        {
            return service.GetMotherBoardInfo();
        }

    }
}
