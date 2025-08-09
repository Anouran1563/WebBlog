namespace WebBlog.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string FeaturedImgUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime DoC { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
