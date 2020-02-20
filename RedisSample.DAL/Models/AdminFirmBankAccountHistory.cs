namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.AdminFirmBankAccountHistory")]
    public partial class AdminFirmBankAccountHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AdminFirmID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProductID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid AdminFirmAccountID { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortID { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string KurumKodu { get; set; }

        public string KurumAltKodu { get; set; }
    }
}
