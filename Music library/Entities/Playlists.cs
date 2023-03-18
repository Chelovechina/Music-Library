namespace Music_library.Entities
{
    public class Playlists
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }
    }
}
