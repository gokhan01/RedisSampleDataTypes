namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.ZiraatFileHistory")]
    public partial class ZiraatFileHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UploadUserID { get; set; }

        public Guid? SendUserID { get; set; }

        public DateTime? SendedDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid AdminFirmID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ZiraatFileTransactionId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfirmOrder { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsSent { get; set; }

        public string Count { get; set; }

        [Key]
        [Column(Order = 6)]
        public double Amount { get; set; }

        public string CurrencyCode { get; set; }

        public string Description { get; set; }

        public string LastMessage { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool LastMessageSeen { get; set; }

        public int? Priority { get; set; }

        [StringLength(2)]
        public string Status { get; set; }

        public int? ExpenseFund { get; set; }

        public string BranchCode { get; set; }

        public bool? HasEFTProcess { get; set; }

        public string ReferansNo { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortID { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string AccountNumber { get; set; }

        public string AccountNumberExtra { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkItemId { get; set; }

        public DateTime? LastMessageSeenDate { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemTypeId { get; set; }

        public string CancelDescription { get; set; }
    }
}
