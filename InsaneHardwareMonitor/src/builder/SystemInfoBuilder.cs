﻿using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using InsaneHardwareMonitor.src.model;

namespace InsaneHardwareMonitor.src.builder
{
    class SystemInfoBuilder
    {

        public SystemInfo Build(MotherBoardInfo motherBoard, CpuInfo cpu, GpuInfo gpu, RamInfo ram, IEnumerable<DriveDiskInfo> driveDisks)
        {
            return new SystemInfo()
            {
                Name = GetName(),
                MotherBoard = motherBoard,
                Cpu = cpu,
                Gpu = gpu,
                Ram = ram,
                DriveDisks = driveDisks
            };
        }

        private string GetName()
        {
            return Environment.MachineName;
        }

    }
}
