namespace MVCStructure_2022.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set;}
        public virtual ICollection<Album> Albums { get; set; }


    }
}
