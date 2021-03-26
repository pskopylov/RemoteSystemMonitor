using OpenHardwareMonitor.Hardware;
using SystemMonitorServer.src.computer;

namespace SystemMonitorServer.src.service
{
    abstract class HardwareService
    {
 
        protected Computer computer;

        protected HardwareService()
        {
            this.computer = ComputerInitializer.Initialize();
            InitBuilder();
        }

        protected HardwareService(Computer computer)
        {
            this.computer = computer;
            InitBuilder();
        }

        protected abstract void InitBuilder();

    }
}
