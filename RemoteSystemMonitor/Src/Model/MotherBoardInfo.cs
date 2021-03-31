using System.Collections.Generic;

namespace RemoteSystemMonitor.Src.Model
{
    public class MotherBoardInfo
    {
        public string Name { get; set; }
        public IEnumerable<FanInfo> FanInfos { get; set; }
    }
}
