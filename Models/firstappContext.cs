using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Grocer.Models
{
    public partial class firstappContext : DbContext
    {
        public firstappContext()
        {
        }

        public firstappContext(DbContextOptions<firstappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductOrder> ProductOrder { get; set; }
        public virtual DbSet<Queries> Queries { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorOrder> VendorOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=firstapp;Uid=root;Pwd=chirag1998;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address", "firstapp");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("Customer_Id");

                entity.Property(e => e.AddressId)
                    .HasColumnName("Address_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("address_ibfk_1");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("bill", "firstapp");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("Customer_Id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Order_Id");

                entity.HasIndex(e => e.ProductId)
                    .HasName("Product_Id");

                entity.Property(e => e.BillId)
                    .HasColumnName("Bill_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasColumnType("double(10,4)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bill_ibfk_3");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bill_ibfk_1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bill_ibfk_2");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart", "firstapp");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Order_Id");

                entity.HasIndex(e => e.ProductId)
                    .HasName("Product_Id");

                entity.Property(e => e.CartId)
                    .HasColumnName("Cart_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cart_ibfk_1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cart_ibfk_2");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer", "firstapp");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate)
                    .HasColumnName("Join_date")
                    .HasColumnType("date");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("bigint(255)");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("delivery", "firstapp");

                entity.HasIndex(e => e.AddressId)
                    .HasName("Address_Id");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("Employee_Id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Order_Id");

                entity.Property(e => e.DeliveryId)
                    .HasColumnName("Delivery_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddressId)
                    .HasColumnName("Address_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeliveryStatus)
                    .IsRequired()
                    .HasColumnName("Delivery_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PaymentStatus)
                    .IsRequired()
                    .HasColumnName("Payment_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("delivery_ibfk_3");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("delivery_ibfk_2");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("delivery_ibfk_1");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee", "firstapp");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasColumnName("Employee_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePosition)
                    .IsRequired()
                    .HasColumnName("Employee_Position")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("bigint(255)");

                entity.Property(e => e.Salary).HasColumnType("double(10,4)");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("inventory", "firstapp");

                entity.HasIndex(e => e.ProductId)
                    .HasName("Product_Id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventory_ibfk_1");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product", "firstapp");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("double(10,4)");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasColumnName("Product_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("Product_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("product_order", "firstapp");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("Customer_Id");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .HasColumnType("int(11)");
                entity.Property(e => e.ProductId)
                   .HasColumnName("Product_Id")
                   .HasColumnType("int(11)");



                entity.Property(e => e.OrderPaymentStatus)
                    .IsRequired()
                    .HasColumnName("Order_Payment_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_order_ibfk_1");
            });

            modelBuilder.Entity<Queries>(entity =>
            {
                entity.HasKey(e => e.QueryId);

                entity.ToTable("queries", "firstapp");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("Employee_Id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Order_Id");

                entity.Property(e => e.QueryId)
                    .HasColumnName("Query_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cquery)
                    .IsRequired()
                    .HasColumnName("cquery")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qstatus)
                    .IsRequired()
                    .HasColumnName("qstatus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Queries)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("queries_ibfk_2");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Queries)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("queries_ibfk_1");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendor", "firstapp");

                entity.Property(e => e.VendorId)
                    .HasColumnName("Vendor_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate)
                    .HasColumnName("Join_date")
                    .HasColumnType("date");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("bigint(255)");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasColumnName("Vendor_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorOrder>(entity =>
            {
                entity.ToTable("vendor_order", "firstapp");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Order_Id");

                entity.HasIndex(e => e.VendorId)
                    .HasName("Vendor_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentStatus)
                    .IsRequired()
                    .HasColumnName("Payment_Status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("Vendor_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.VendorOrder)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vendor_order_ibfk_1");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorOrder)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vendor_order_ibfk_2");
            });
        }
    }
}
