using CourseStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.DAL.Contexts
{
    public class CourseStoreDbContext : DbContext
    {
        #region [-DbSets-]

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        #endregion


        #region [-Ctor-]
        public CourseStoreDbContext(DbContextOptions<CourseStoreDbContext> options) : base(options)
        {
        }
        #endregion
        #region [-ConfigureConventions-]

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<string>().HaveMaxLength(100);
        }

        #endregion

        #region [-OnModelCreating-]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        } 
        #endregion
    }
}
