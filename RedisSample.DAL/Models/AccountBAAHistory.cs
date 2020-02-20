namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.AccountBAAHistory")]
    public partial class AccountBAAHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

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
    }
}
