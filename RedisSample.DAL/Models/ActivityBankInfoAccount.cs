namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessInfo.ActivityBankInfoAccount")]
    public partial class ActivityBankInfoAccount
    {
        public Guid ID { get; set; }

        public string IBAN { get; set; }

        public string BankBranchCode { get; set; }

        public string AccountNumber { get; set; }

        public string AccountSuffix { get; set; }

        public DateTime StartScanDate { get; set; }

        public string CurrencyCode { get; set; }

        public Guid ActivityBankInfoID { get; set; }

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

        public virtual ActivityBankInfo ActivityBankInfo { get; set; }
    }
}
