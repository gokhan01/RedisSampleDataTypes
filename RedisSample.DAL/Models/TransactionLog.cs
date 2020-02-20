namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log_.TransactionLog")]
    public partial class TransactionLog
    {
        public Guid ID { get; set; }

        public bool Status { get; set; }

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

        public string RequestBody { get; set; }

        public byte WorkerType { get; set; }

        public string ExceptionCode { get; set; }

        public string ExceptionMessage { get; set; }

        public Guid? BankID { get; set; }

        public Guid? AdminFirmID { get; set; }
    }
}
