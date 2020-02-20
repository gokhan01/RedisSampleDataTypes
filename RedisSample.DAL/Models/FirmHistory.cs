namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.FirmHistory")]
    public partial class FirmHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string CityCode { get; set; }

        public string RegionID { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string TaxOffice { get; set; }

        public string TaxNumber { get; set; }

        public string TcNo { get; set; }

        public string FirmBranchNumber { get; set; }

        public string Address { get; set; }

        public string CardNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AdminFirmID { get; set; }

        public string SurName { get; set; }

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

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FirmType { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FirmClass { get; set; }
    }
}
