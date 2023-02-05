namespace MSS_NewsWeb.Models
{
    public class FileData
    {
        public byte[] Data { get; set; }
        public string FileType { get; set; }
        public long Size { get; set; }

        public Guid Guid
        {
            get
            {
                return Guid.NewGuid();
            }
        }

    }
}
