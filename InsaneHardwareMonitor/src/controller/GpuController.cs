using System.Web.Http;
using InsaneHardwareMonitor.src.model;
using InsaneHardwareMonitor.src.service;

namespace InsaneHardwareMonitor.src.controller
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
