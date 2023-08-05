namespace BlogWebApp.Models.Domain
{
    public class BlogPost
    {
        //step 1: create these properties
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        //step 3: this blogpost can have multiple tags. hence creating many to many relationship
        //for that create new property
        public ICollection<Tag> Tags { get; set; }

    }
}
