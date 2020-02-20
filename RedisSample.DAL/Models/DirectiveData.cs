namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.DirectiveData")]
    public partial class DirectiveData
    {
        public Guid ID { get; set; }

        public int RowNumber { get; set; }

        public string IBAN { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

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

        public Guid? FirmID { get; set; }

        public Guid DirectiveID { get; set; }

        public string FirmName { get; set; }

        public string VKN { get; set; }

        public virtual Firm Firm { get; set; }

        public virtual Directive Directive { get; set; }
    }
}
