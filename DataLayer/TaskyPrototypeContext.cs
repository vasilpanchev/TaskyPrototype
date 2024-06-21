using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TaskyPrototypeContext : DbContext
    {
        public TaskyPrototypeContext() : base() { }

        public TaskyPrototypeContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder
                .Entity<UserTask>()
                .HasOne<User>(t => t.User)
                 .WithMany(u => u.Tasks)
                 .HasForeignKey(t => t.Username)
                 .HasConstraintName("FK_Username");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JUJFLLB;Database=TaskyPrototypeDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
    }
}
