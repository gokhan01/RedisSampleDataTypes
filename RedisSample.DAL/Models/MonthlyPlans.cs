namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction_.MonthlyPlans")]
    public partial class MonthlyPlans
    {
        public Guid ID { get; set; }

        public DateTime ActivityDate { get; set; }

        public double Amount { get; set; }

        public Guid AdminFirmID { get; set; }

        public byte AccountActivityStatusValue { get; set; }

        public string Description { get; set; }

        public string CurrencyCode { get; set; }

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

        public Guid FirmID { get; set; }

        public virtual Firm Firm { get; set; }
    }
}
