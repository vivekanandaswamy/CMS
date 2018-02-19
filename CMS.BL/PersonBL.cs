using System.Text;
using System.Threading.Tasks;
using CMS.DAL;
using CMS.DAL.Models;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
namespace CMS.BL
{
    public class PersonBL
    {
        PersonDAL _personDAL;
        public PersonBL()
        {
            var conn = new SqlConnection();
            _personDAL = new PersonDAL(conn);
        }
        public int InsertPersons(Person _person)
        {
            return _personDAL.InsertPersons(_person);
        }
        public int InsertPersonDetails(PersonDetails _personDetails)
        {
            return _personDAL.InsertPersonDetails(_personDetails);
        }
        public DataTable FetchPersons()
        {
            return _personDAL.FetchPersons();
        }
        public DataTable FetchPersonDetails()
        {
            return _personDAL.FetchPersonDetails();
        }
    }
}
