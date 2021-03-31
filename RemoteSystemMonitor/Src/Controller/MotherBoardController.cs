using System.Web.Http;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Service;

namespace RemoteSystemMonitor.Src.Сontroller
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
