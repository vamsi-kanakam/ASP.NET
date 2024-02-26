namespace MVCStructure.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public Artist Artist { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string RecordLabel { get; set; }
        public int CopiesSold { get; set; }
        public int Streams { get; set; }
    }
}
