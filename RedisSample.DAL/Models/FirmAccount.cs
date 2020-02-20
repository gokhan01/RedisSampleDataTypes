namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firm.FirmAccount")]
    public partial class FirmAccount
    {
        public Guid ID { get; set; }

        public string IBAN { get; set; }

        public Guid BankID { get; set; }

        public Guid AdminFirmID { get; set; }

        public Guid FirmID { get; set; }

        public bool IsDefault { get; set; }

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

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string AccountNumber { get; set; }

        public string AccountNumberExtra { get; set; }

        public virtual Firm Firm { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
