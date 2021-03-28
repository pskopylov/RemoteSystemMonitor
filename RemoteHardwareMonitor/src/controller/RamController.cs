using System.Web.Http;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Service;

namespace RemoteHardwareMonitor.Src.Сontroller
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
