namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction_.AdminFirmAccount")]
    public partial class AdminFirmAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdminFirmAccount()
        {
            Directive = new HashSet<Directive>();
            InvoiceHeader = new HashSet<InvoiceHeader>();
            SalaryHeader = new HashSet<SalaryHeader>();
            TaxHeader = new HashSet<TaxHeader>();
            AdminFirmBankAccount = new HashSet<AdminFirmBankAccount>();
            AccountActivity = new HashSet<AccountActivity>();
        }

        public Guid ID { get; set; }

        public Guid AdminFirmID { get; set; }

        public string IBAN { get; set; }

        public double Balance { get; set; }

        public double UsableBalance { get; set; }

        public DateTime? OpenDate { get; set; }

        public string BankBranchCode { get; set; }

        public string BankBranchName { get; set; }

        public string AccountNumber { get; set; }

        public string AccountNumberExtra { get; set; }

        public string CurrencyCode { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        public string MaasIslemKodlari { get; set; }

        public Guid? BankID { get; set; }

        public byte? Type { get; set; }

        public virtual Bank Bank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Directive> Directive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceHeader> InvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryHeader> SalaryHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxHeader> TaxHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminFirmBankAccount> AdminFirmBankAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountActivity> AccountActivity { get; set; }
    }
}
