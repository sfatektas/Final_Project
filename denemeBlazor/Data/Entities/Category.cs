namespace SportsStore.Data.Entities
{
    public class Category : BaseEntity
    {
        public string Defination { get; set; }

        public List<Post> Posts { get; set; }
    }
}
