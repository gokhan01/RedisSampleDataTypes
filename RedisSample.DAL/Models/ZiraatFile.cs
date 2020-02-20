namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("File_.ZiraatFile")]
    public partial class ZiraatFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZiraatFile()
        {
            ZiraatFileContent = new HashSet<ZiraatFileContent>();
        }

        public Guid ID { get; set; }

        public Guid UploadUserID { get; set; }

        public Guid? SendUserID { get; set; }

        public DateTime? SendedDate { get; set; }

        public Guid AdminFirmID { get; set; }

        public Guid ZiraatFileTransactionId { get; set; }

        public int ConfirmOrder { get; set; }

        public bool IsSent { get; set; }

        public string Count { get; set; }

        public double Amount { get; set; }

        public string CurrencyCode { get; set; }

        public string Description { get; set; }

        public string LastMessage { get; set; }

        public bool LastMessageSeen { get; set; }

        public int? Priority { get; set; }

        [StringLength(2)]
        public string Status { get; set; }

        public int? ExpenseFund { get; set; }

        public string BranchCode { get; set; }

        public bool? HasEFTProcess { get; set; }

        public string ReferansNo { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string AccountNumber { get; set; }

        public string AccountNumberExtra { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        public int WorkItemId { get; set; }

        public DateTime? LastMessageSeenDate { get; set; }

        public int ItemTypeId { get; set; }

        public string CancelDescription { get; set; }

        public virtual AdminFirm AdminFirm { get; set; }

        public virtual AdminUser AdminUser { get; set; }

        public virtual AdminUser AdminUser1 { get; set; }

        public virtual ZiraatFileTransaction ZiraatFileTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiraatFileContent> ZiraatFileContent { get; set; }
    }
}
