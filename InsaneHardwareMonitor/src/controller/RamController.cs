using System.Web.Http;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.service;

namespace InsaneHardwareMonitor.src.controller
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
