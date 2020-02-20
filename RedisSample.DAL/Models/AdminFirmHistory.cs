namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.AdminFirmHistory")]
    public partial class AdminFirmHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Mono { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsBankCustomer { get; set; }

        public string CompanyCode { get; set; }

        public string VKN { get; set; }

        public string Email { get; set; }

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

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string PSR { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WrongAccessCount { get; set; }

        public DateTime? AgreementDate { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsAgreementApproval { get; set; }

        public string dynamicpsr { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsTransactionQueryDone { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsApproveStarted { get; set; }
    }
}
