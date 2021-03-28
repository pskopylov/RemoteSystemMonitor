namespace RemoteHardwareMonitor.Src.Model
{
    public class DriveDiskInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DriveName { get; set; }
        public float? Temperature { get; set; }
        public ulong TotalSpace { get; set; }
        public ulong FreeSpace { get; set; }
    }
}
