using System.Web.Http;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Service;

namespace RemoteSystemMonitor.Src.Сontroller
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
