namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.DirectiveDetail")]
    public partial class DirectiveDetail
    {
        public Guid ID { get; set; }

        public int nkyId { get; set; }

        public int nkyDetayId { get; set; }

        public DateTime odemeTarihi { get; set; }

        public string tutar { get; set; }

        public string talimatNo { get; set; }

        public string odemeKodu { get; set; }

        public int bankaKodu { get; set; }

        public int subeKodu { get; set; }

        public string hesapNo { get; set; }

        public string durumuKodu { get; set; }

        public string durumuKoduAciklama { get; set; }

        public float eftKomisyonTutari { get; set; }

        public float eftBsmvTutari { get; set; }

        public DateTime guncellemeTarihi { get; set; }

        public string babaAdi { get; set; }

        public string vergiTcKimlikNo { get; set; }

        public string kayitDurumu { get; set; }

        public string kayitTrxKod { get; set; }

        public string ad { get; set; }

        public string soyad { get; set; }

        public string aciklama { get; set; }

        public int hataKodu { get; set; }

        public string hataAciklama { get; set; }

        public string kayitYapan { get; set; }

        public DateTime kayitZamani { get; set; }

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
    }
}
