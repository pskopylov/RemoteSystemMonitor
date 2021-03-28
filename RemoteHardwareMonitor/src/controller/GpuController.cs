using System.Web.Http;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Service;

namespace RemoteHardwareMonitor.Src.Сontroller
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
