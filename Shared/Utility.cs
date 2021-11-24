using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BSM.Shared
{
   public class Utility
    {
        public SqlConnection connect = new SqlConnection(@"server=52.172.134.222;database=IMSET;user id=IMSETUser; Password=imset123@786;");
        public int UserId { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int OpCode { get; set; }
        public DataSet DS { get; set; }
        public bool IsException { get; set; }
        public string ExceptionMessage { get; set; }
    }

    public class CommonResponse
    {
        public int status { get; set; }
        public string message { get; set; }
        public object responseValue { get; set; }
    }
}
