using OpenHardwareMonitor.Hardware;
using RemoteSystemMonitor.Src.OHMComputer;

namespace RemoteSystemMonitor.Src.Service
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
