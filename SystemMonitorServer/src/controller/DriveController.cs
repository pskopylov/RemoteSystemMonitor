using System.Collections.Generic;
using System.Web.Http;
using SystemMonitorServer.src.model;
using SystemMonitorServer.src.service;

namespace SystemMonitorServer.src.controller
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
