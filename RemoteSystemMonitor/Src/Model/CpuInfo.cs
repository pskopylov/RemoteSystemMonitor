namespace RemoteSystemMonitor.Src.Model
{
    public class CpuInfo
    {
        public string Name { get; set; }
        public int? PhysicalCores { get; set; }
        public int? LogicalCores { get; set; }
        public float? TotalLoad { get; set; }
        public float?[] CoreLoads { get; set; }
        public float?[] CoreClocks { get; set; }
        public float? Temperature { get; set; }
    }
}
