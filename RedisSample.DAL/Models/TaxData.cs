namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.TaxData")]
    public partial class TaxData
    {
        public Guid ID { get; set; }

        public string faturaVergiKod { get; set; }

        public string faturaVergiDaireKod { get; set; }

        public string faturaDonem { get; set; }

        public string faturaTaksitNo { get; set; }

        public string faturaKrediKartTaksitDurum { get; set; }

        public string kod { get; set; }

        public string aciklama { get; set; }

        public string kartNo { get; set; }

        public string kartTaksitDurum { get; set; }

        public string islemAciklama { get; set; }

        public string kurumRefNo { get; set; }

        public string odemeDurum { get; set; }

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

        public string faturaAboneNo { get; set; }

        public string muhasebeSubeKod { get; set; }

        public string muhasebeRef { get; set; }

        public string muhasebeTarih { get; set; }

        public virtual TaxHeader TaxHeader { get; set; }
    }
}
