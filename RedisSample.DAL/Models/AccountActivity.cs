namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction_.AccountActivity")]
    public partial class AccountActivity
    {
        public Guid ID { get; set; }

        public DateTime ActivityDate { get; set; }

        public int? BankBranchCode { get; set; }

        [StringLength(30)]
        public string AccountNumber { get; set; }

        public int? BankCode { get; set; }

        [StringLength(30)]
        public string IBAN { get; set; }

        public double Amount { get; set; }

        public Guid AdminFirmID { get; set; }

        [StringLength(100)]
        public string ReferenceNumber { get; set; }

        public byte AccountActivityStatusValue { get; set; }

        public bool IsBankActivity { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(5)]
        public string CurrencyCode { get; set; }

        [StringLength(20)]
        public string VKN { get; set; }

        [StringLength(20)]
        public string AccountActivityTypeBankCode { get; set; }

        public bool IsSendErp { get; set; }

        public Guid? FirmID { get; set; }

        public Guid AdminFirmAccountID { get; set; }

        public Guid? BankID { get; set; }

        public Guid? AccountActivityTypeID { get; set; }

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

        [StringLength(250)]
        public string FirmName { get; set; }

        [StringLength(30)]
        public string FirmCode { get; set; }

        public byte MatchingField { get; set; }

        public virtual Firm Firm { get; set; }

        public virtual Bank Bank { get; set; }

        public virtual AccountActivityType AccountActivityType { get; set; }

        public virtual AdminFirmAccount AdminFirmAccount { get; set; }
    }
}
