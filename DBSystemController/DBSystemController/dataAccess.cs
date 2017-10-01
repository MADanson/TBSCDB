using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace DBSystemController
{
    public class dataAccess
    {
        public List<Item> GetItems(string query)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStr("TBSCDB")))
            {
                var output = connection.Query<Item>(query).ToString();
                return output;
            }

        }
    }
}
