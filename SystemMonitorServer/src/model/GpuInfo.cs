namespace SystemMonitorServer.src.model
{
    public class GpuInfo
    {
        public string Name { get; set; }
        public float? CoreTemperature { get; set; }
        public float? CoreClock { get; set; }
        public float? CoreLoad { get; set; }
        public float? MemoryLoad { get; set; }
        public float? MemoryClock { get; set; }
        public float? MemoryTotal { get; set; }
        public float? MemoryUsed { get; set; }
        public float? MemoryFree { get; set; }
        public FanInfo FanInfo { get; set; }
    }
}
