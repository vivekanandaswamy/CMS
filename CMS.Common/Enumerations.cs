using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Common
{
    public enum DataType
    {
        Odbc = 1,
        SqlServer = 2
    };

    public enum ConnectionStringMode
    {
        OdbcConnectionString = 1,
        SqlServerConnectionString = 2
    };
}
