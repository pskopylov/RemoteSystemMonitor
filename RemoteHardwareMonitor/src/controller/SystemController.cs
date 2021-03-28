using System.Web.Http;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Service;

namespace RemoteHardwareMonitor.Src.Сontroller
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
