using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class MdemyDBPOSContext : DbContext
    {
        public MdemyDBPOSContext()
        {
        }

        public MdemyDBPOSContext(DbContextOptions<MdemyDBPOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAdjustment> TbAdjustments { get; set; }
        public virtual DbSet<TbBrand> TbBrands { get; set; }
        public virtual DbSet<TbCancel> TbCancels { get; set; }
        public virtual DbSet<TbCart> TbCarts { get; set; }
        public virtual DbSet<TbCategory> TbCategories { get; set; }
        public virtual DbSet<TbProduct> TbProducts { get; set; }
        public virtual DbSet<TbStockIn> TbStockIns { get; set; }
        public virtual DbSet<TbStore> TbStores { get; set; }
        public virtual DbSet<TbSupplier> TbSuppliers { get; set; }
        public virtual DbSet<TbUser> TbUsers { get; set; }
        public virtual DbSet<VwCancelItem> VwCancelItems { get; set; }
        public virtual DbSet<VwCriticalItem> VwCriticalItems { get; set; }
        public virtual DbSet<VwInventoryList> VwInventoryLists { get; set; }
        public virtual DbSet<VwStockIn> VwStockIns { get; set; }
        public virtual DbSet<VwTopSelling> VwTopSellings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QEQ96AO;Initial Catalog=MdemyDBPOS;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TbAdjustment>(entity =>
            {
                entity.ToTable("tbAdjustment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Referenceno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("referenceno");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Sdate)
                    .HasColumnType("date")
                    .HasColumnName("sdate");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user");
            });

            modelBuilder.Entity<TbBrand>(entity =>
            {
                entity.ToTable("tbBrand");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand");
            });

            modelBuilder.Entity<TbCancel>(entity =>
            {
                entity.ToTable("tbCancel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action");

                entity.Property(e => e.Cancelledby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cancelledby");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Reason)
                    .HasColumnType("text")
                    .HasColumnName("reason");

                entity.Property(e => e.Sdate)
                    .HasColumnType("date")
                    .HasColumnName("sdate");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.Transno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transno");

                entity.Property(e => e.Voidby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voidby");
            });

            modelBuilder.Entity<TbCart>(entity =>
            {
                entity.ToTable("tbCart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cashier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cashier");

                entity.Property(e => e.Disc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("disc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("disc_percent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sdate)
                    .HasColumnType("date")
                    .HasColumnName("sdate");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.Transno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transno");

                entity.HasOne(d => d.PcodeNavigation)
                    .WithMany(p => p.TbCarts)
                    .HasForeignKey(d => d.Pcode)
                    .HasConstraintName("FK_tbCart_tbProduct");
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.ToTable("tbCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");
            });

            modelBuilder.Entity<TbProduct>(entity =>
            {
                entity.HasKey(e => e.Pcode)
                    .HasName("PK_tbProduct_1");

                entity.ToTable("tbProduct");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pdesc)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reorder).HasColumnName("reorder");

                entity.HasOne(d => d.BidNavigation)
                    .WithMany(p => p.TbProducts)
                    .HasForeignKey(d => d.Bid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbProduct_tbBrand");
            });

            modelBuilder.Entity<TbStockIn>(entity =>
            {
                entity.ToTable("tbStockIn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Refno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refno");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sdate");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.Stockinby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockinby");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.HasOne(d => d.PcodeNavigation)
                    .WithMany(p => p.TbStockIns)
                    .HasForeignKey(d => d.Pcode)
                    .HasConstraintName("FK_tbStockIn_tbProduct");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TbStockIns)
                    .HasForeignKey(d => d.Supplierid)
                    .HasConstraintName("FK_tbStockIn_tbSupplier");
            });

            modelBuilder.Entity<TbStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbStore");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Store)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store");
            });

            modelBuilder.Entity<TbSupplier>(entity =>
            {
                entity.ToTable("tbSupplier");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Contactperson)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactperson");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Supplier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("tbUser");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Isactivate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isactivate")
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<VwCancelItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCancelItems");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action");

                entity.Property(e => e.Cancelledby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cancelledby");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Pdesc)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Reason)
                    .HasColumnType("text")
                    .HasColumnName("reason");

                entity.Property(e => e.Sdate)
                    .HasColumnType("date")
                    .HasColumnName("sdate");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.Transno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transno");

                entity.Property(e => e.Voidby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voidby");
            });

            modelBuilder.Entity<VwCriticalItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCriticalItems");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Pdesc)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Reorder).HasColumnName("reorder");
            });

            modelBuilder.Entity<VwInventoryList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInventoryList");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Pdesc)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Reorder).HasColumnName("reorder");
            });

            modelBuilder.Entity<VwStockIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStockIn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Pdesc)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Refno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refno");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sdate");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Stockinby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockinby");

                entity.Property(e => e.Supplier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier");
            });

            modelBuilder.Entity<VwTopSelling>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTopSelling");

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pcode");

                entity.Property(e => e.Pdesc)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sdate)
                    .HasColumnType("date")
                    .HasColumnName("sdate");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
