using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL
{
    public class User
    {
        public int uid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string uname { get; set; }
        public string passwd { get; set; }
        public string conpasswd { get; set; }
    }
}
