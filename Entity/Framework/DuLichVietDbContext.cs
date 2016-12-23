namespace Entity.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DuLichVietDbContext : DbContext
    {
        public DuLichVietDbContext()
            : base("data source=DESKTOP-MMURNVC\\SQLEXPRESS;initial catalog=DuLichViet;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Tourist_Group> Tourist_Group { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.Madoan)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Cmnd)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Places)
                .WithRequired(e => e.Province)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.Matour)
                .IsUnicode(false);

            modelBuilder.Entity<Tourist_Group>()
                .Property(e => e.Madoan)
                .IsUnicode(false);

            modelBuilder.Entity<Tourist_Group>()
                .Property(e => e.Matour)
                .IsUnicode(false);
        }
    }
}
