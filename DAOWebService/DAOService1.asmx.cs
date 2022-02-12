using System.Web.Services;
using static DAOWebService.Connections;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DAOWebService
{
    /// <summary>
    /// Summary description for DAOService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DAOService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void Create(string nom, int annee, string resultat, string machine, string ip)
        {
            Users u = new Users(nom, annee, resultat, machine, ip);
            Connections.InsertUser(u);
            
        }
        [WebMethod]
        public List<Users> ZeUsers()
        {
            List<Users> UserList = Connections.AllUsers();
            return UserList;
        }
    }
}
