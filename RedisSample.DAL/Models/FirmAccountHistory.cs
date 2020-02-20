namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.FirmAccountHistory")]
    public partial class FirmAccountHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string IBAN { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BankID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid AdminFirmID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid FirmID { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsDefault { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortID { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string AccountNumber { get; set; }

        public string AccountNumberExtra { get; set; }
    }
}
