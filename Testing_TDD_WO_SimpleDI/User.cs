using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_TDD_WO_SimpleDI;

namespace TDD_App
{
    public class User
    {
        private string firstName;

        public string FirstName {
            get {
                var databaseConnection = new DatabaseConnection();
                return databaseConnection.GetData();
            }
            set {
                firstName = value;
            }
        }
    }
}
