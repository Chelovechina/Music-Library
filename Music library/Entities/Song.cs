namespace Music_library.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public Album Album { get; set; }
        public TimeOnly Duration { get; set; }
        public DateTime Release_Date { get; set; }
    }
}
