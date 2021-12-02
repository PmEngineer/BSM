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
            cmd.Parameters.AddWithValue("@company_name", pobj.company_name);
            cmd.Parameters.AddWithValue("@Address", pobj.Address);
            cmd.Parameters.AddWithValue("@city_id", pobj.city_id);
            cmd.Parameters.AddWithValue("@states_id", pobj.states_id);
            cmd.Parameters.AddWithValue("@country_id", pobj.country_id);
            cmd.Parameters.AddWithValue("@zip_code", pobj.zip_code);
            cmd.Parameters.AddWithValue("@phone_number", pobj.phone_number);
            cmd.Parameters.AddWithValue("@email", pobj.email);
            cmd.Parameters.AddWithValue("@gst_number", pobj.gst_number);
            cmd.Parameters.AddWithValue("@companyType_id", pobj.companyType_id);
            cmd.Parameters.AddWithValue("@StartDate", pobj.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", pobj.EndDate);
            cmd.Parameters.AddWithValue("@url", pobj.url);
            cmd.Parameters.AddWithValue("@dependent_unit_id", pobj.dependent_unit_id);
            cmd.Parameters.AddWithValue("@Location", pobj.Location);
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
