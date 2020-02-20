namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("File_.ZiraatFileTransaction")]
    public partial class ZiraatFileTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZiraatFileTransaction()
        {
            ZiraatFile = new HashSet<ZiraatFile>();
        }

        public Guid ID { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        public bool HasEFTProcess { get; set; }

        public string CurrencyCode { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        public string Description { get; set; }

        public int Code { get; set; }

        public bool IsRequiredAmount { get; set; }

        public bool IsRequiredCount { get; set; }

        public bool IsRequiredDescription { get; set; }

        public bool IsRequiredExpenseFund { get; set; }

        public bool IsRequiredPriority { get; set; }

        public string PoolCode { get; set; }

        public Guid? ProductPropertyID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiraatFile> ZiraatFile { get; set; }

        public virtual ProductProperty ProductProperty { get; set; }
    }
}
