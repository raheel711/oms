using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace oms.Models
{
    public partial class omsContext : DbContext
    {
        public omsContext()
        {
        }

        public omsContext(DbContextOptions<omsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusinessSetting> BusinessSetting { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderAccount> OrderAccount { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OutsourceResource> OutsourceResource { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerAccount> PartnerAccount { get; set; }
        public virtual DbSet<Product> Product { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=MIS-RAHEEL\\SQLEXPRESS;Database=oms;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BusinessSetting>(entity =>
            {
                entity.ToTable("business_Setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(150);

                entity.Property(e => e.BusinessName)
                    .HasColumnName("business_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessSlogon)
                    .HasColumnName("business_slogon")
                    .HasMaxLength(150);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.LogoUrl)
                    .HasColumnName("logo_url")
                    .HasMaxLength(150);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("mobile_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnPolicy)
                    .HasColumnName("return_policy")
                    .HasMaxLength(250);

                entity.Property(e => e.TermsConditions)
                    .HasColumnName("terms_conditions")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("customer");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustAddress)
                    .HasColumnName("cust_address")
                    .HasMaxLength(150);

                entity.Property(e => e.CustCompany)
                    .HasColumnName("cust_company")
                    .HasMaxLength(50);

                entity.Property(e => e.CustContactNo)
                    .HasColumnName("cust_contact_no")
                    .HasMaxLength(50);

                entity.Property(e => e.CustEmail)
                    .HasColumnName("cust_email")
                    .HasMaxLength(50);

                entity.Property(e => e.CustName)
                    .HasColumnName("cust_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CustWhatsapp)
                    .HasColumnName("cust_whatsapp")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.ToTable("expense");

                entity.Property(e => e.ExpenseId).HasColumnName("expense_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountStatus).HasColumnName("amount_status");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(250);

                entity.Property(e => e.EDate)
                    .HasColumnName("e_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifyBy).HasColumnName("modify_by");

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderAccountId).HasColumnName("order_account_id");

                entity.Property(e => e.PaidAmount)
                    .HasColumnName("paid_amount")
                    .HasMaxLength(10);

                entity.Property(e => e.PaidBy).HasColumnName("paid_by");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkStatus)
                    .HasColumnName("work_status")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentAmount).HasColumnName("current_amount");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(350);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpenseAmount).HasColumnName("expense_amount");

                entity.Property(e => e.ExtraAmount).HasColumnName("extra_amount");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(150);

                entity.Property(e => e.ModifyBy).HasColumnName("modify_by");

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningAmount).HasColumnName("opening_amount");

                entity.Property(e => e.OrderAssignTo).HasColumnName("order_assign_to");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderTakenBy).HasColumnName("order_taken_by");

                entity.Property(e => e.PaidAmount).HasColumnName("paid_amount");

                entity.Property(e => e.PriceIsFinal)
                    .HasColumnName("price_is_final")
                    .HasMaxLength(10);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OrderAccount>(entity =>
            {
                entity.ToTable("order_account");

                entity.Property(e => e.OrderAccountId).HasColumnName("order_account_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AmountTakenBy).HasColumnName("amount_taken_by");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(150);

                entity.Property(e => e.ModifyBy).HasColumnName("modify_by");

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ReceviedAmount).HasColumnName("recevied_amount");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("order_detail");

                entity.Property(e => e.OrderDetailId).HasColumnName("order_detail_id");

                entity.Property(e => e.CustPrice).HasColumnName("cust_price");

                entity.Property(e => e.CustQty).HasColumnName("cust_qty");

                entity.Property(e => e.ModifyBy).HasColumnName("modify_by");

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OutsourceResource>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.ToTable("outsource_resource");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(150);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("partner");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerDetail)
                    .HasColumnName("partner_detail")
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerEmail)
                    .HasColumnName("partner_email")
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerName)
                    .HasColumnName("partner_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerStatus).HasColumnName("partner_status");

                entity.Property(e => e.SuPassword)
                    .HasColumnName("su_password")
                    .HasMaxLength(50);

                entity.Property(e => e.SuRoles)
                    .HasColumnName("su_roles")
                    .HasMaxLength(50);

                entity.Property(e => e.SuStatus).HasColumnName("su_status");

                entity.Property(e => e.SuUsername)
                    .HasColumnName("su_username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PartnerAccount>(entity =>
            {
                entity.ToTable("partner_account");

                entity.Property(e => e.PartnerAccountId).HasColumnName("partner_account_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountGivenBy).HasColumnName("amount_given_by");

                entity.Property(e => e.OrderAccountId).HasColumnName("order_account_id");

                entity.Property(e => e.ReceivedAcceptDate)
                    .HasColumnName("received_accept_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AddedBy).HasColumnName("added_by");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasMaxLength(150);

                entity.Property(e => e.EstimatePrice).HasColumnName("estimate_price");

                entity.Property(e => e.ModifyBy).HasColumnName("modify_by");

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(50);
            });
        }
    }
}
