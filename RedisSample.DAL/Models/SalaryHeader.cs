namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.SalaryHeader")]
    public partial class SalaryHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalaryHeader()
        {
            SalaryData = new HashSet<SalaryData>();
        }

        public Guid ID { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public string CurrencyCode { get; set; }

        public string CancelDescription { get; set; }

        public string TotalPiece { get; set; }

        public string TotalPrice { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PayrollNo { get; set; }

        public int PermissionOrder { get; set; }

        public double PostedPrice { get; set; }

        public int? firmaMaasNo { get; set; }

        public Guid AdminFirmID { get; set; }

        public Guid AdminFirmAccountID { get; set; }

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

        public int IslemKd { get; set; }

        public bool IsTransactionStart { get; set; }

        public virtual AdminFirm AdminFirm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryData> SalaryData { get; set; }

        public virtual AdminFirmAccount AdminFirmAccount { get; set; }
    }
}
