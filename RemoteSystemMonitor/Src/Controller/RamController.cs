using System.Web.Http;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Service;

namespace RemoteSystemMonitor.Src.Сontroller
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
