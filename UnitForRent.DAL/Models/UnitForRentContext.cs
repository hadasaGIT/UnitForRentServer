using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class UnitForRentContext : DbContext
    {
        public UnitForRentContext()
        {
        }

        public UnitForRentContext(DbContextOptions<UnitForRentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAnswersForRent> TblAnswersForRents { get; set; }
        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblFeedback> TblFeedbacks { get; set; }
        public virtual DbSet<TblFurnitureLevel> TblFurnitureLevels { get; set; }
        public virtual DbSet<TblHousingUnit> TblHousingUnits { get; set; }
        public virtual DbSet<TblHousingUnitImage> TblHousingUnitImages { get; set; }
        public virtual DbSet<TblHousingUnitRelevant> TblHousingUnitRelevants { get; set; }
        public virtual DbSet<TblManager> TblManagers { get; set; }
        public virtual DbSet<TblQuestionsForRent> TblQuestionsForRents { get; set; }
        public virtual DbSet<TblSearch> TblSearches { get; set; }
        public virtual DbSet<TblUnitOwner> TblUnitOwners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UnitForRent;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<TblAnswersForRent>(entity =>
            {
                entity.HasKey(e => e.AnswersId)
                    .HasName("PK__tbl_Answ__E5771E39B448FD68");

                entity.ToTable("tbl_AnswersForRent");

                entity.Property(e => e.AnswersId)
                    .ValueGeneratedNever()
                    .HasColumnName("AnswersID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionsId).HasColumnName("QuestionsID");

                entity.HasOne(d => d.Answers)
                    .WithOne(p => p.TblAnswersForRent)
                    .HasForeignKey<TblAnswersForRent>(d => d.AnswersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Answe__Answe__412EB0B6");

                entity.HasOne(d => d.Questions)
                    .WithMany(p => p.TblAnswersForRents)
                    .HasForeignKey(d => d.QuestionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Answe__Quest__4222D4EF");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tbl_Customers");

                entity.Property(e => e.Id)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phon1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phon2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFeedback>(entity =>
            {
                entity.ToTable("tbl_Feedback");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomersId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CustomersID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HousingUnitId).HasColumnName("HousingUnitID");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.TblFeedbacks)
                    .HasForeignKey(d => d.CustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Feedb__Custo__45F365D3");

                entity.HasOne(d => d.HousingUnit)
                    .WithMany(p => p.TblFeedbacks)
                    .HasForeignKey(d => d.HousingUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Feedb__Housi__44FF419A");
            });

            modelBuilder.Entity<TblFurnitureLevel>(entity =>
            {
                entity.ToTable("tbl_FurnitureLevel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHousingUnit>(entity =>
            {
                entity.ToTable("tbl_HousingUnits");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EvacuationDate).HasColumnType("date");

                entity.Property(e => e.OccupancyDate).HasColumnType("date");

                entity.Property(e => e.PublishDate).HasColumnType("date");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOwnersId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("UnitOwnersID");

                entity.HasOne(d => d.FurnitureNavigation)
                    .WithMany(p => p.TblHousingUnits)
                    .HasForeignKey(d => d.Furniture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Housi__Furni__37A5467C");

                entity.HasOne(d => d.UnitOwners)
                    .WithMany(p => p.TblHousingUnits)
                    .HasForeignKey(d => d.UnitOwnersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Housi__UnitO__36B12243");
            });

            modelBuilder.Entity<TblHousingUnitImage>(entity =>
            {
                entity.HasKey(e => e.HousingUnitId)
                    .HasName("PK__tbl_Hous__F47C5F5307B210C0");

                entity.ToTable("tbl_HousingUnitImages");

                entity.Property(e => e.HousingUnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("HousingUnitID");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.HousingUnit)
                    .WithOne(p => p.TblHousingUnitImage)
                    .HasForeignKey<TblHousingUnitImage>(d => d.HousingUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Housi__Housi__3A81B327");
            });

            modelBuilder.Entity<TblHousingUnitRelevant>(entity =>
            {
                entity.HasKey(e => new { e.CustomersId, e.HousingUnitId })
                    .HasName("PK__tbl_Hous__C41C9DEB1D4EA405");

                entity.ToTable("tbl_HousingUnitRelevant");

                entity.Property(e => e.CustomersId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CustomersID");

                entity.Property(e => e.HousingUnitId).HasColumnName("HousingUnitID");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.TblHousingUnitRelevants)
                    .HasForeignKey(d => d.CustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Housi__Custo__49C3F6B7");

                entity.HasOne(d => d.HousingUnit)
                    .WithMany(p => p.TblHousingUnitRelevants)
                    .HasForeignKey(d => d.HousingUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Housi__Housi__48CFD27E");
            });

            modelBuilder.Entity<TblManager>(entity =>
            {
                entity.ToTable("tbl_Managers");

                entity.Property(e => e.Id)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phon1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phon2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuestionsForRent>(entity =>
            {
                entity.HasKey(e => e.QuestionsId)
                    .HasName("PK__tbl_Ques__877DE8BB67D461BC");

                entity.ToTable("tbl_QuestionsForRent");

                entity.Property(e => e.QuestionsId)
                    .ValueGeneratedNever()
                    .HasColumnName("QuestionsID");

                entity.Property(e => e.CustomersId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CustomersID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HousingUnitId).HasColumnName("HousingUnitID");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.TblQuestionsForRents)
                    .HasForeignKey(d => d.CustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Quest__Custo__3D5E1FD2");

                entity.HasOne(d => d.HousingUnit)
                    .WithMany(p => p.TblQuestionsForRents)
                    .HasForeignKey(d => d.HousingUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Quest__Housi__3E52440B");
            });

            modelBuilder.Entity<TblSearch>(entity =>
            {
                entity.HasKey(e => new { e.CustomersId, e.SearchId })
                    .HasName("PK__tbl_Sear__B9470B4F3B9318D8");

                entity.ToTable("tbl_Search");

                entity.Property(e => e.CustomersId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CustomersID");

                entity.Property(e => e.SearchId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SearchID");

                entity.Property(e => e.DateSearch).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EvacuationDate).HasColumnType("date");

                entity.Property(e => e.OccupancyDate).HasColumnType("date");

                entity.Property(e => e.PublishDate).HasColumnType("date");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOwnersId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("UnitOwnersID");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.TblSearches)
                    .HasForeignKey(d => d.CustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Searc__Custo__4CA06362");

                entity.HasOne(d => d.FurnitureNavigation)
                    .WithMany(p => p.TblSearches)
                    .HasForeignKey(d => d.Furniture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Searc__Furni__4E88ABD4");

                entity.HasOne(d => d.UnitOwners)
                    .WithMany(p => p.TblSearches)
                    .HasForeignKey(d => d.UnitOwnersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Searc__UnitO__4D94879B");
            });

            modelBuilder.Entity<TblUnitOwner>(entity =>
            {
                entity.ToTable("tbl_UnitOwners");

                entity.Property(e => e.Id)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phon1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phon2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
