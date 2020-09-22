using Microsoft.EntityFrameworkCore;
using SherrysWall.DAL.Models;
using System;

namespace SherrysWall.DAL
{
    public class SherrysWallContext:DbContext
    {
        public SherrysWallContext(DbContextOptions<SherrysWallContext> options)
            : base(options)
        {
           
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}
