using System.Collections.Generic;

namespace SystemMonitorServer.src.model
{
    public class MotherBoardInfo
    {
        public string Name { get; set; }
        public IEnumerable<FanInfo> FanInfos { get; set; }
    }
}
