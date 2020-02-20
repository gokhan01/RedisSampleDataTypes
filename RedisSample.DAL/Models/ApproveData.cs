namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Form.ApproveData")]
    public partial class ApproveData
    {
        public Guid ID { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

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

        public int Table { get; set; }

        public int Property { get; set; }

        public string Value { get; set; }

        public int Type { get; set; }

        public int ProductType { get; set; }

        public string TableID { get; set; }

        public string GroupID { get; set; }

        public bool HideInView { get; set; }

        [StringLength(20)]
        public string Mono { get; set; }

        public Guid? AdminFirmID { get; set; }
    }
}
