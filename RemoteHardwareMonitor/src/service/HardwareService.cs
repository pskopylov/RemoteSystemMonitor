using OpenHardwareMonitor.Hardware;
using RemoteHardwareMonitor.Src.OHMComputer;

namespace RemoteHardwareMonitor.Src.Service
{
    abstract class HardwareService
    {
 
        protected Computer computer;

        protected HardwareService()
        {
            computer = ComputerInitializer.Initialize();
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
