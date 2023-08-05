namespace BlogWebApp.Models.Domain
{
    public class Tag
    {
        //step 2: create these properties
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        //step 4: one tag can have mutiple blogpost. hence completing the many to many connection here
        //which is created in the blogpost model
        public ICollection<BlogPost> BlogPosts { get; set; }

    }
}

// step 5: now install following packages for Entity framework core.
// Dependencies > Manage NuGet packages
// 1)Microsoft.EntityFrameworkCore.sqlServer, 2)Microsoft.EntityFrameworkCore.Tools

