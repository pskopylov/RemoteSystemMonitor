﻿using System.Collections.Generic;

namespace RemoteSystemMonitor.Src.Model
{
    public class SystemInfo
    {
        public string Name { get; set; }
        public MotherBoardInfo MotherBoard { get; set; }
        public CpuInfo Cpu { get; set; }
        public GpuInfo Gpu { get; set; }
        public RamInfo Ram { get; set; }
        public IEnumerable<DriveDiskInfo> DriveDisks { get; set; }
    }
}