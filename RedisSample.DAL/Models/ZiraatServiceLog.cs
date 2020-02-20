namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log_.ZiraatServiceLog")]
    public partial class ZiraatServiceLog
    {
        public Guid ID { get; set; }

        public bool Status { get; set; }

        public string Message { get; set; }

        public string InnerExceptionMessage { get; set; }

        public string RequestModel { get; set; }

        public string ResponseModel { get; set; }

        public string RequestUri { get; set; }

        public string ExceptionModel { get; set; }

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

        public Guid? AdminFirmID { get; set; }
    }
}
