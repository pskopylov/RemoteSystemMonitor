using System.Collections.Generic;
using System.Web.Http;
using RemoteHardwareMonitor.Src.Model;
using RemoteHardwareMonitor.Src.Service;

namespace RemoteHardwareMonitor.Src.Сontroller
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
