namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.OperationUserHistory")]
    public partial class OperationUserHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string DomainName { get; set; }

        public string UserAccessKey { get; set; }

        public string OperationRoles { get; set; }

        public string Phone { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RejCnt { get; set; }

        public DateTime? BannedDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortID { get; set; }

        public string RecordNumber { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsApprover { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleNumber { get; set; }

        public string BranchCode { get; set; }

        public string ProductRoles { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
