namespace LabDay1EFR.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ITIContext : DbContext
    {
        public ITIContext()
            : base("name=ITIContext")
        {
        }

        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<instructor> instructors { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<department>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .HasMany(e => e.instructors)
                .WithOptional(e => e.department)
                .HasForeignKey(e => e.dept_id);

            modelBuilder.Entity<instructor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.passowrd)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.cv)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.photo)
                .IsUnicode(false);
        }
    }
}
