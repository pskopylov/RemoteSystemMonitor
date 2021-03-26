using System.Collections.Generic;

namespace SystemMonitorServer.src.model
{
    public class SystemInfo
    {
        public MotherBoardInfo MotherBoard { get; set; }
        public CpuInfo Cpu { get; set; }
        public GpuInfo Gpu { get; set; }
        public RamInfo Ram { get; set; }
        public IEnumerable<DriveDiskInfo> DriveDisks { get; set; }
    }
}
