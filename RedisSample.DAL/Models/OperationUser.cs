namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login_.OperationUser")]
    public partial class OperationUser
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string DomainName { get; set; }

        public string UserAccessKey { get; set; }

        public string OperationRoles { get; set; }

        public string Phone { get; set; }

        public int RejCnt { get; set; }

        public DateTime? BannedDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        public string RecordNumber { get; set; }

        public bool IsApprover { get; set; }

        public int RoleNumber { get; set; }

        public string BranchCode { get; set; }

        public string ProductRoles { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
