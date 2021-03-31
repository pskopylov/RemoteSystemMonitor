using System.Collections.Generic;
using System.Web.Http;
using RemoteSystemMonitor.Src.Model;
using RemoteSystemMonitor.Src.Service;

namespace RemoteSystemMonitor.Src.Сontroller
{
    public class DriveController : ApiController
    {
        private readonly DriveInfoService service = new DriveInfoService();

        public IEnumerable<DriveDiskInfo> Get()
        {
            return service.GetDriveInfos();
        }

        public DriveDiskInfo GetByName(string name)
        {
            return service.GetDriveInfo(name);
        }

    }
}
