namespace MVCStructure_2022.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public int TrackNumber { get; set; }
        public string Title { get; set; }
        public int? AlbumID { get; set; }
        public virtual Album Album { get; set; }
    }
}
