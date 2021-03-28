using System.Web.Http;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.service;

namespace InsaneHardwareMonitor.src.controller
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
