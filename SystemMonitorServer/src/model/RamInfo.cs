namespace SystemMonitorServer.src.model
{
    public class RamInfo
    {
        public string Name { get; set; }
        public float? Load { get; set; }
        public float? UsedMemory { get; set; }
        public float? AvailableMemory { get; set; }

    }
}
