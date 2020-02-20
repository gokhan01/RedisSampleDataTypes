namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.InvoiceDetail")]
    public partial class InvoiceDetail
    {
        public Guid ID { get; set; }

        public string kurumKod { get; set; }

        public string kurumAltKod { get; set; }

        public string kurumAd { get; set; }

        public string siraNo { get; set; }

        public string faturaNo { get; set; }

        public string faturaTutar { get; set; }

        public string tahsilTutar { get; set; }

        public string odemeDurum { get; set; }

        public string odemeAciklama { get; set; }

        public string faturaAciklama { get; set; }

        public string kod { get; set; }

        public string aciklama { get; set; }

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

        public Guid HeaderID { get; set; }
    }
}
