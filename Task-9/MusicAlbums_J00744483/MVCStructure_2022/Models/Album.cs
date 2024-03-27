namespace MVCStructure_2022.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int? ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

    }
}
