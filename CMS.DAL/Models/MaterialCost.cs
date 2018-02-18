using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Models
{
    public class MaterialCost
    {
        public int emcid { get; set; }
        public int mid { get; set; }
        public int mdid { get; set; }
        public int tmid { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public string comments { get; set; }
    }
}
