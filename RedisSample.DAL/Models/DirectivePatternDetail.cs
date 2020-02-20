namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.DirectivePatternDetail")]
    public partial class DirectivePatternDetail
    {
        public Guid ID { get; set; }

        public int StartIndex { get; set; }

        public string PropertyName { get; set; }

        public Guid DirectivePatternID { get; set; }

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

        public int Length { get; set; }

        public byte DataType { get; set; }

        public virtual DirectivePattern DirectivePattern { get; set; }
    }
}
