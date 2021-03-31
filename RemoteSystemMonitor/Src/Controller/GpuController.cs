using System.Web.Http;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Service;

namespace RemoteSystemMonitor.Src.Сontroller
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
