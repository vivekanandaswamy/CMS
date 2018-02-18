using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Models
{
    public class LabourCost
    {
        public int elcid { get; set; }
        public int rpid { get; set; }
        public int pid { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public string comments { get; set; }
    }
}
