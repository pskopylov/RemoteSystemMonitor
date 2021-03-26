

using OpenHardwareMonitor.Hardware;

namespace InsaneHardwareMonitor.src.computer
{
    class ComputerInitializer
    {
        public static Computer Initialize()
        {
            var visitor = new Visitor();
            var computer = new Computer()
            {
                MainboardEnabled = true,
                CPUEnabled = true,
                RAMEnabled = true,
                GPUEnabled = true,
                FanControllerEnabled = true,
                HDDEnabled = true,
            };
            computer.Open();
            computer.Accept(visitor);
            return computer;
        }
    }
}
