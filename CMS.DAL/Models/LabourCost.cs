using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Models
{
    public class LabourCost
    {
        public int lcid { get; set; }
        public int rpid { get; set; }
        public int pid { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public int qtypurchased { get; set; }
        public DateTime dateofpurchase { get; set; }
        public DateTime dateofenquiry { get; set; }
        public string comments { get; set; }
    }
}
