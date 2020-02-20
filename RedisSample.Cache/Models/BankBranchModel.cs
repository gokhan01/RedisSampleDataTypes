using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSample.Cache.Models
{
    public class BankBranchModel : BaseEntity
    {
        public Guid ID { get; set; }

        public string BankID { get; set; }

        public int BranchCode { get; set; }

        public string BranchName { get; set; }

        public string BranchCityCode { get; set; }

        public string BranchCityName { get; set; }

        public string BranchRegionCode { get; set; }

        public string BranchRegionName { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
