using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Models
{
   public class PersonDetails
    {
        public int pid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int rpid { get; set; }
        public string mobile1 { get; set; }
        public string mobile2 { get; set; }
        public string email { get; set; }
        public string comments { get; set; }
    }
}
