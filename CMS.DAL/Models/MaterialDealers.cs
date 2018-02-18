using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Models
{
    public class MaterialDealers
    {
        public int mdid { get; set; }
        public int tmid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public string comments { get; set; }
    }
}
