// step 6: Create a dbContext class. This class is bridge between Domain class (Entities) and Database
// it is responsible for interacting with database and performs CRUD operations using entity framework core
// inherit this BlogDbContext from DbContext (Ctrl + .)


using BlogWebApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApp.Data
{
    public class BlogDbContext : DbContext
    {
        // step 7: Create constructor with options parameter (Ctrl + .)
        public BlogDbContext(DbContextOptions options) : base(options)
        {

        }
        // step 7: create property for BlogPost Domain class
        public DbSet<BlogPost> BlogPosts { get; set; }

        // step 8: create property for Tag Domain class
        public DbSet<Tag> Tags { get; set; }

    }
}

// step 9: These 2 tables BlogPosts and Tags in the database are connected with each other by Many to many 
// relationships. to attach them we have to create 1 more table.