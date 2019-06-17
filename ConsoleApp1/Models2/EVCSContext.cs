using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1.Models2
{
    public partial class EVCSContext : DbContext
    {
        public EVCSContext()
        {
        }

        public EVCSContext(DbContextOptions<EVCSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarInfos> CarInfos { get; set; }
        public virtual DbSet<CarTasks> CarTasks { get; set; }
        public virtual DbSet<Count> Count { get; set; }
        public virtual DbSet<PersonTasks> PersonTasks { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<SerialNumber> SerialNumber { get; set; }
        public virtual DbSet<SerialNumberRecords> SerialNumberRecords { get; set; }
        public virtual DbSet<Singlevolume> Singlevolume { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VolumeDetail> VolumeDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.192.11.215;database=EVCS;User Id = suhuyuan;Password = PointCloud;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<CarInfos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CarNo)
                    .HasColumnName("CarNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Volume).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<CarTasks>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.TaskDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Count>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hight)
                    .HasColumnName("hight")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Wide)
                    .HasColumnName("wide")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<PersonTasks>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.TaskDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Records>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CarNo).HasColumnName("CarNO");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LoadingRate).HasColumnName("Loading rate");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Volume).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<SerialNumber>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateFormat).HasMaxLength(50);

                entity.Property(e => e.Prefix).HasMaxLength(50);
            });

            modelBuilder.Entity<SerialNumberRecords>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CarNo).HasColumnName("CarNO");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Singlevolume>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreadTime).HasColumnType("datetime");

                entity.Property(e => e.Volume).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<VolumeDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(28, 20)");
            });
        }
    }
}
