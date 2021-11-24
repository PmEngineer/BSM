using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BSM.Shared.Model;

namespace BSM.Shared.Dal
{
  public  class DalMaster
    {
        public static void returnTable(Masters  pobj)
        {
            SqlCommand cmd = new SqlCommand("proc_master", pobj.connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", pobj.name);
            
            cmd.Parameters.AddWithValue("@CreatedBy", pobj.CreatedBy);
            cmd.Parameters.AddWithValue("@opCode", pobj.OpCode);
            cmd.Parameters.Add("@isException", SqlDbType.Bit);
            cmd.Parameters["@isException"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@exceptionMessage", SqlDbType.VarChar, 500);
            cmd.Parameters["@exceptionMessage"].Direction = ParameterDirection.Output;
            SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);
            pobj.DS = new DataSet();
            sqlAdp.Fill(pobj.DS);
            pobj.IsException = Convert.ToBoolean(cmd.Parameters["@isException"].Value);
            pobj.ExceptionMessage = cmd.Parameters["@exceptionMessage"].Value.ToString();
        }

    }
}
