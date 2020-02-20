namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment.OfflineDirective")]
    public partial class OfflineDirective
    {
        public Guid ID { get; set; }

        public string Host { get; set; }

        public string Port { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EMail { get; set; }

        public string InputFolder { get; set; }

        public string OutputFolder { get; set; }

        public bool IsRequireConfirm { get; set; }

        public Guid AdminFirmID { get; set; }

        public Guid AdminFirmBankAccountID { get; set; }

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

        public Guid DirectivePatternID { get; set; }

        public virtual AdminFirm AdminFirm { get; set; }

        public virtual DirectivePattern DirectivePattern { get; set; }

        public virtual AdminFirmBankAccount AdminFirmBankAccount { get; set; }
    }
}
