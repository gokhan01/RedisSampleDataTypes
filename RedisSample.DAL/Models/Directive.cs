namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.Directive")]
    public partial class Directive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Directive()
        {
            DirectiveData = new HashSet<DirectiveData>();
        }

        public Guid ID { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public string CurrencyCode { get; set; }

        public string CancelDescription { get; set; }

        public string TotalPrice { get; set; }

        public double PostedPrice { get; set; }

        public DateTime PaymentDate { get; set; }

        public int PermissionOrder { get; set; }

        public Guid AdminFirmID { get; set; }

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

        public string TotalPiece { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public string PayrollNo { get; set; }

        public Guid AdminFirmAccountID { get; set; }

        public int? nkyId { get; set; }

        public bool IsTransactionStart { get; set; }

        public virtual AdminFirm AdminFirm { get; set; }

        public virtual AdminFirmAccount AdminFirmAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirectiveData> DirectiveData { get; set; }
    }
}
