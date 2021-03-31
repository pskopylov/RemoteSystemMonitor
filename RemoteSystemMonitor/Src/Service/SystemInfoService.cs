using System.Collections.Generic;
using RemoteSystemMonitor.Src.Builder;
using RemoteSystemMonitor.Src.Model;

namespace RemoteSystemMonitor.Src.Service
{
    class SystemInfoService : HardwareService
    {
        private readonly MotherBoardService motherBoardService;
        private readonly CpuInfoService cpuInfoService;
        private readonly GpuInfoService gpuInfoService;
        private readonly RamInfoService ramInfoService;
        private readonly DriveInfoService driveInfoService;

        private SystemInfoBuilder builder;

        public SystemInfoService() : base()
        {
            motherBoardService = new MotherBoardService(computer);
            cpuInfoService = new CpuInfoService(computer);
            gpuInfoService = new GpuInfoService(computer);
            ramInfoService = new RamInfoService(computer);
            driveInfoService = new DriveInfoService(computer);
        }


        protected override void InitBuilder()
        {
            builder = new SystemInfoBuilder();
        }

        public SystemInfo GetSystemInfo()
        {
            MotherBoardInfo motherBoard = motherBoardService.GetMotherBoardInfo();
            CpuInfo cpu = cpuInfoService.GetCpuInfo();
            GpuInfo gpu = gpuInfoService.GetGpuInfo();
            RamInfo ram = ramInfoService.GetRamInfo();
            IEnumerable<DriveDiskInfo> driveDisks = driveInfoService.GetDriveInfos();
            return builder.Build(motherBoard, cpu, gpu, ram, driveDisks);
        }


    }
}
