namespace Music_library.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public string Country { get; set; }
        public List<Album> Albums { get; set; }
    }
}
