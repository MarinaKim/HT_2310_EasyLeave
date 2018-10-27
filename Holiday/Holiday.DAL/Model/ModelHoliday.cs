namespace Holiday.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelHoliday : DbContext
    {
        public ModelHoliday()
            : base("name=ModelHoliday")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ApplicationData> tbl_ApplicationData { get; set; }
        public virtual DbSet<tbl_CityDetails> tbl_CityDetails { get; set; }
        public virtual DbSet<tbl_Country> tbl_Country { get; set; }
        public virtual DbSet<tbl_Dept> tbl_Dept { get; set; }
        public virtual DbSet<tbl_Designation> tbl_Designation { get; set; }
        public virtual DbSet<tbl_EmpDetails> tbl_EmpDetails { get; set; }
        public virtual DbSet<tbl_LeaveType> tbl_LeaveType { get; set; }
        public virtual DbSet<tbl_Sanction> tbl_Sanction { get; set; }
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_ApplicationData>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ApplicationData>()
                .Property(e => e.LeavePurpose)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ApplicationData>()
                .Property(e => e.ApplicationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CityDetails>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CityDetails>()
                .Property(e => e.CityDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Country>()
                .Property(e => e.CounryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Country>()
                .Property(e => e.CountryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Designation>()
                .Property(e => e.DesigType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Designation>()
                .Property(e => e.DesigDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_EmpDetails>()
                .Property(e => e.EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_EmpDetails>()
                .Property(e => e.EmpDesigName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_EmpDetails>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_EmpDetails>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_EmpDetails>()
                .Property(e => e.ContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_EmpDetails>()
                .Property(e => e.UserName)
                .IsUnicode(false);
        }
    }
}
