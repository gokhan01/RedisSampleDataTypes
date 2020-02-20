namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log_.ExceptionLog")]
    public partial class ExceptionLog
    {
        public Guid ID { get; set; }

        public string ProjectName { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string ExceptionMessage { get; set; }

        public string Detail { get; set; }

        public Guid? AdminFirmID { get; set; }

        public Guid? AdminUserID { get; set; }

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

        public virtual AdminFirm AdminFirm { get; set; }

        public virtual AdminUser AdminUser { get; set; }
    }
}
