namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.ProductPropertyValueHistory")]
    public partial class ProductPropertyValueHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ProductPropertyID { get; set; }

        public string AdminFirmProductID { get; set; }

        public string Value { get; set; }

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

        [Key]
        [Column(Order = 7)]
        public bool IsSelected { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
