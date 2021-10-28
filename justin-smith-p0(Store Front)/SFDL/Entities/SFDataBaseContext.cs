using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SFDL.Entities
{
    public partial class SFDataBaseContext : DbContext
    {
        public SFDataBaseContext()
        {
        }

        public SFDataBaseContext(DbContextOptions<SFDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SOrder> SOrders { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer");

                entity.Property(e => e.CustAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_address");

                entity.Property(e => e.CustEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_email");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");

                entity.Property(e => e.CustPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cust_phone");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inventory");

                entity.Property(e => e.ProdId).HasColumnName("prod_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("line_item");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProdId).HasColumnName("prod_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product");

                entity.Property(e => e.ProdDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prod_description");

                entity.Property(e => e.ProdId).HasColumnName("prod_id");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prod_name");

                entity.Property(e => e.ProdPrice).HasColumnName("prod_price");
            });

            modelBuilder.Entity<SOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("s_order");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("store");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_address");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
