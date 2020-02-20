namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History.DirectiveHistory")]
    public partial class DirectiveHistory
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        public string CurrencyCode { get; set; }

        public string CancelDescription { get; set; }

        public string TotalPrice { get; set; }

        [Key]
        [Column(Order = 2)]
        public double PostedPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime PaymentDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PermissionOrder { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid AdminFirmID { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortID { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        public string TotalPiece { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string PayrollNo { get; set; }

        [Key]
        [Column(Order = 13)]
        public Guid AdminFirmAccountID { get; set; }

        public int? nkyId { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IsTransactionStart { get; set; }
    }
}
