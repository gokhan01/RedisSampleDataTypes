namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.AdminUserHistory")]
    public partial class AdminUserHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        public string Roles { get; set; }

        [Key]
        [Column(Order = 1)]
        public double TOSSendLimit { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool TOSRole { get; set; }

        public string SecurityCode { get; set; }

        public string DirectiveSecurityCode { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsSuperAdmin { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RejCnt { get; set; }

        public DateTime? BannedDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid AdminFirmID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TOSPermissionOrder { get; set; }

        public string ZiraatFileSecurityCode { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool ZiraatFileSendAuthority { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsLastApprover { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortID { get; set; }

        public string MaasSecurityCode { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ZiraatFileOrder { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public DateTime? LastSingOutDate { get; set; }

        public string InvoiceSecurityCode { get; set; }

        public string TaxSecurityCode { get; set; }
    }
}
