namespace WebApplication_OOP.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //Связь многие ко многим
        public List<PostTag>? PostTags { get; set; } = new List<PostTag>();
    }
}
