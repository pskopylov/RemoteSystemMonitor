﻿using System.Collections.Generic;
using SystemMonitorServer.src.model;

namespace SystemMonitorServer.src.builder
{
    class SystemInfoBuilder
    {

        public SystemInfo Build(MotherBoardInfo motherBoard, CpuInfo cpu, GpuInfo gpu, RamInfo ram, IEnumerable<DriveDiskInfo> driveDisks)
        {
            return new SystemInfo()
            {
                MotherBoard = motherBoard,
                Cpu = cpu,
                Gpu = gpu,
                Ram = ram,
                DriveDisks = driveDisks
            };
        }

    }
}
