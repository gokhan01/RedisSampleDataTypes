namespace RedisSample.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login_.AdminUser")]
    public partial class AdminUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdminUser()
        {
            ZiraatFile = new HashSet<ZiraatFile>();
            ZiraatFile1 = new HashSet<ZiraatFile>();
            ExceptionLog = new HashSet<ExceptionLog>();
            UserLog = new HashSet<UserLog>();
            AdminFirmBankAccountUser = new HashSet<AdminFirmBankAccountUser>();
        }

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        public string Roles { get; set; }

        public double TOSSendLimit { get; set; }

        public bool TOSRole { get; set; }

        public string SecurityCode { get; set; }

        public string DirectiveSecurityCode { get; set; }

        public bool IsSuperAdmin { get; set; }

        public int RejCnt { get; set; }

        public DateTime? BannedDate { get; set; }

        public Guid AdminFirmID { get; set; }

        public int TOSPermissionOrder { get; set; }

        public string ZiraatFileSecurityCode { get; set; }

        public bool ZiraatFileSendAuthority { get; set; }

        public bool IsLastApprover { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SortID { get; set; }

        public string MaasSecurityCode { get; set; }

        public int ZiraatFileOrder { get; set; }

        public string UpdatedUserID { get; set; }

        public string InsertedUserID { get; set; }

        public string DeletedUserID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }

        public DateTime? LastSingOutDate { get; set; }

        public string InvoiceSecurityCode { get; set; }

        public string TaxSecurityCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiraatFile> ZiraatFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiraatFile> ZiraatFile1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExceptionLog> ExceptionLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLog> UserLog { get; set; }

        public virtual AdminFirm AdminFirm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminFirmBankAccountUser> AdminFirmBankAccountUser { get; set; }
    }
}
