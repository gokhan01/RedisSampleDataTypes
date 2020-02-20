namespace RedisSample.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ParaticZiraatDevDB")
        {
        }

        public virtual DbSet<AccountBAA> AccountBAA { get; set; }
        public virtual DbSet<AccountBAABank> AccountBAABank { get; set; }
        public virtual DbSet<ActivityBankInfo> ActivityBankInfo { get; set; }
        public virtual DbSet<ActivityBankInfoAccount> ActivityBankInfoAccount { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ZiraatFile> ZiraatFile { get; set; }
        public virtual DbSet<ZiraatFileContent> ZiraatFileContent { get; set; }
        public virtual DbSet<ZiraatFileContentData> ZiraatFileContentData { get; set; }
        public virtual DbSet<ZiraatFileTransaction> ZiraatFileTransaction { get; set; }
        public virtual DbSet<Firm> Firm { get; set; }
        public virtual DbSet<FirmAccount> FirmAccount { get; set; }
        public virtual DbSet<ApproveData> ApproveData { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankBranch> BankBranch { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CurrencyCode> CurrencyCode { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLog { get; set; }
        public virtual DbSet<RepositoryLog> RepositoryLog { get; set; }
        public virtual DbSet<TransactionLog> TransactionLog { get; set; }
        public virtual DbSet<TransactionODataLog> TransactionODataLog { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<ZiraatServiceLog> ZiraatServiceLog { get; set; }
        public virtual DbSet<AdminFirm> AdminFirm { get; set; }
        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<OperationUser> OperationUser { get; set; }
        public virtual DbSet<Directive> Directive { get; set; }
        public virtual DbSet<DirectiveData> DirectiveData { get; set; }
        public virtual DbSet<DirectiveDetail> DirectiveDetail { get; set; }
        public virtual DbSet<DirectivePattern> DirectivePattern { get; set; }
        public virtual DbSet<DirectivePatternDetail> DirectivePatternDetail { get; set; }
        public virtual DbSet<InvoiceData> InvoiceData { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public virtual DbSet<OfflineDirective> OfflineDirective { get; set; }
        public virtual DbSet<SalaryData> SalaryData { get; set; }
        public virtual DbSet<SalaryHeader> SalaryHeader { get; set; }
        public virtual DbSet<TaxData> TaxData { get; set; }
        public virtual DbSet<TaxHeader> TaxHeader { get; set; }
        public virtual DbSet<AdminFirmBankAccount> AdminFirmBankAccount { get; set; }
        public virtual DbSet<AdminFirmBankAccountUser> AdminFirmBankAccountUser { get; set; }
        public virtual DbSet<AdminFirmProduct> AdminFirmProduct { get; set; }
        public virtual DbSet<OperationRoles> OperationRoles { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductProperty> ProductProperty { get; set; }
        public virtual DbSet<ProductPropertyValue> ProductPropertyValue { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<AccountActivity> AccountActivity { get; set; }
        public virtual DbSet<AccountActivityType> AccountActivityType { get; set; }
        public virtual DbSet<AccountActivityTypeByBank> AccountActivityTypeByBank { get; set; }
        public virtual DbSet<AdminFirmAccount> AdminFirmAccount { get; set; }
        public virtual DbSet<MonthlyPlans> MonthlyPlans { get; set; }
        public virtual DbSet<AccountBAABankHistory> AccountBAABankHistory { get; set; }
        public virtual DbSet<AccountBAAHistory> AccountBAAHistory { get; set; }
        public virtual DbSet<AdminFirmBankAccountHistory> AdminFirmBankAccountHistory { get; set; }
        public virtual DbSet<AdminFirmBankAccountUserHistory> AdminFirmBankAccountUserHistory { get; set; }
        public virtual DbSet<AdminFirmHistory> AdminFirmHistory { get; set; }
        public virtual DbSet<AdminFirmProductHistory> AdminFirmProductHistory { get; set; }
        public virtual DbSet<AdminUserHistory> AdminUserHistory { get; set; }
        public virtual DbSet<DirectiveHistory> DirectiveHistory { get; set; }
        public virtual DbSet<FirmAccountHistory> FirmAccountHistory { get; set; }
        public virtual DbSet<FirmHistory> FirmHistory { get; set; }
        public virtual DbSet<OperationUserHistory> OperationUserHistory { get; set; }
        public virtual DbSet<ProductPropertyValueHistory> ProductPropertyValueHistory { get; set; }
        public virtual DbSet<ZiraatFileHistory> ZiraatFileHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountBAA>()
                .HasMany(e => e.AccountBAABank)
                .WithRequired(e => e.AccountBAA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityBankInfo>()
                .HasMany(e => e.ActivityBankInfoAccount)
                .WithRequired(e => e.ActivityBankInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZiraatFile>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ZiraatFile>()
                .HasMany(e => e.ZiraatFileContent)
                .WithRequired(e => e.ZiraatFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZiraatFileContentData>()
                .HasMany(e => e.ZiraatFileContent)
                .WithRequired(e => e.ZiraatFileContentData)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZiraatFileTransaction>()
                .HasMany(e => e.ZiraatFile)
                .WithRequired(e => e.ZiraatFileTransaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Firm>()
                .HasMany(e => e.FirmAccount)
                .WithRequired(e => e.Firm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Firm>()
                .HasMany(e => e.MonthlyPlans)
                .WithRequired(e => e.Firm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Firm>()
                .HasMany(e => e.SalaryData)
                .WithRequired(e => e.Firm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bank>()
                .HasMany(e => e.AccountBAABank)
                .WithRequired(e => e.Bank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bank>()
                .HasMany(e => e.ActivityBankInfo)
                .WithRequired(e => e.Bank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bank>()
                .HasMany(e => e.FirmAccount)
                .WithRequired(e => e.Bank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.ZiraatFile)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.AdminFirmProduct)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.AdminUser)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.Directive)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.InvoiceHeader)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.SalaryHeader)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.TaxHeader)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirm>()
                .HasMany(e => e.OfflineDirective)
                .WithRequired(e => e.AdminFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminUser>()
                .HasMany(e => e.ZiraatFile)
                .WithOptional(e => e.AdminUser)
                .HasForeignKey(e => e.SendUserID);

            modelBuilder.Entity<AdminUser>()
                .HasMany(e => e.ZiraatFile1)
                .WithRequired(e => e.AdminUser1)
                .HasForeignKey(e => e.UploadUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminUser>()
                .HasMany(e => e.UserLog)
                .WithOptional(e => e.AdminUser)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<AdminUser>()
                .HasMany(e => e.AdminFirmBankAccountUser)
                .WithRequired(e => e.AdminUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Directive>()
                .HasMany(e => e.DirectiveData)
                .WithRequired(e => e.Directive)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DirectivePattern>()
                .HasMany(e => e.DirectivePatternDetail)
                .WithRequired(e => e.DirectivePattern)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DirectivePattern>()
                .HasMany(e => e.OfflineDirective)
                .WithRequired(e => e.DirectivePattern)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceHeader>()
                .HasMany(e => e.InvoiceData)
                .WithRequired(e => e.InvoiceHeader)
                .HasForeignKey(e => e.HeaderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalaryHeader>()
                .HasMany(e => e.SalaryData)
                .WithRequired(e => e.SalaryHeader)
                .HasForeignKey(e => e.HeaderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaxHeader>()
                .HasMany(e => e.TaxData)
                .WithRequired(e => e.TaxHeader)
                .HasForeignKey(e => e.HeaderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmBankAccount>()
                .HasMany(e => e.OfflineDirective)
                .WithRequired(e => e.AdminFirmBankAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmBankAccount>()
                .HasMany(e => e.AdminFirmBankAccountUser)
                .WithRequired(e => e.AdminFirmBankAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.AdminFirmBankAccount)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.AdminFirmProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductProperty)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductProperty>()
                .HasMany(e => e.ProductPropertyValue)
                .WithRequired(e => e.ProductProperty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.ProductProperty)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmAccount>()
                .HasMany(e => e.Directive)
                .WithRequired(e => e.AdminFirmAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmAccount>()
                .HasMany(e => e.InvoiceHeader)
                .WithRequired(e => e.AdminFirmAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmAccount>()
                .HasMany(e => e.SalaryHeader)
                .WithRequired(e => e.AdminFirmAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmAccount>()
                .HasMany(e => e.AdminFirmBankAccount)
                .WithRequired(e => e.AdminFirmAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminFirmAccount>()
                .HasMany(e => e.AccountActivity)
                .WithRequired(e => e.AdminFirmAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZiraatFileHistory>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
