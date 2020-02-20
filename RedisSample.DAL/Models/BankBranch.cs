namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Form.BankBranch")]
    public partial class BankBranch
    {
        public Guid ID { get; set; }

        public string BankID { get; set; }

        public string BankCode { get; set; }

        public int BranchCode { get; set; }

        public string BranchName { get; set; }

        public string BranchCityCode { get; set; }

        public string BranchCityName { get; set; }

        public string BranchRegionCode { get; set; }

        public string BranchRegionName { get; set; }

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
    }
}
