namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.InvoiceData")]
    public partial class InvoiceData
    {
        public Guid ID { get; set; }

        public string faturaKurumKod { get; set; }

        public string faturaKurumAltKod { get; set; }

        public string faturaAboneNo { get; set; }

        public string faturaAboneEkNo { get; set; }

        public int RowNumber { get; set; }

        public Guid HeaderID { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        public string kod { get; set; }

        public string aciklama { get; set; }

        public virtual InvoiceHeader InvoiceHeader { get; set; }
    }
}
