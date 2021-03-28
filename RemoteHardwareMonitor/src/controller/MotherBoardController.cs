using System.Web.Http;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Service;

namespace RemoteHardwareMonitor.Src.Сontroller
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
