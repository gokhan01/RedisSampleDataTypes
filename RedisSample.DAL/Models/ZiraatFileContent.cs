namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("File_.ZiraatFileContent")]
    public partial class ZiraatFileContent
    {
        public Guid ID { get; set; }

        public Guid ZiraatFileID { get; set; }

        public int SortNumber { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        public string Name { get; set; }

        public string Extension { get; set; }

        public double SizeInMB { get; set; }

        public Guid ZiraatFileContentDataID { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        public bool IsMainContent { get; set; }

        public virtual ZiraatFile ZiraatFile { get; set; }

        public virtual ZiraatFileContentData ZiraatFileContentData { get; set; }
    }
}
