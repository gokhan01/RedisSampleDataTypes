namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessInfo.ActivityBankInfo")]
    public partial class ActivityBankInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityBankInfo()
        {
            ActivityBankInfoAccount = new HashSet<ActivityBankInfoAccount>();
        }

        public Guid ID { get; set; }

        public Guid AdminFirmID { get; set; }

        public string UserName { get; set; }

        public string CustomerNumber { get; set; }

        public string Password { get; set; }

        public string FirmName { get; set; }

        public string FirmKey { get; set; }

        public byte WaitMinutePerRequest { get; set; }

        public Guid BankID { get; set; }

        public DateTime StartScanDate { get; set; }

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

        public virtual Bank Bank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityBankInfoAccount> ActivityBankInfoAccount { get; set; }
    }
}
