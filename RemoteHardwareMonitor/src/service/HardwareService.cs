using OpenHardwareMonitor.Hardware;
using InsaneHardwareMonitor.src.computer;

namespace InsaneHardwareMonitor.src.service
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
