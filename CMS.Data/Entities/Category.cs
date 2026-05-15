namespace CMS.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } // Tên danh mục

        public string Description { get; set; }

        // Một danh mục có nhiều bài viết
        public virtual ICollection<Post> Posts { get; set; }
    }
}