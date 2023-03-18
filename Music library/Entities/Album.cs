namespace Music_library.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public DateTime Release_Date { get; set; }
    }
}
