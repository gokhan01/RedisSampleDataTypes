namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log_.UserLog")]
    public partial class UserLog
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid? UserID { get; set; }

        public string IP { get; set; }

        public string IdentityName { get; set; }

        public string Browser { get; set; }

        public string BrowserVersion { get; set; }

        public string ServerName { get; set; }

        public string Addr { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public string City { get; set; }

        public string ServiceName { get; set; }

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

        public string Content { get; set; }

        public Guid? AdminFirmID { get; set; }

        public int? LogCategoryID { get; set; }

        public virtual AdminFirm AdminFirm { get; set; }

        public virtual AdminUser AdminUser { get; set; }
    }
}
