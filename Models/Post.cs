namespace WebApplication_OOP.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        //Связь один ко многим
        public int? UserId { get; set; }
        public User? User { get; set; }
        //Связь многие ко многим
        public List<PostTag>? PostTags { get; set; } = new List<PostTag>();

    }
}
