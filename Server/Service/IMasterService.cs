using System;
using System.Collections.Generic;
using System.Text;
using BSM.Shared;
using BSM.Shared.Model;
using BSM.Shared.Dal;
using Newtonsoft.Json;
namespace BSM.Server.Service
{
   public interface IMasterService
    {
        CommonResponse insertCompanyType(Masters pobj);
        CommonResponse showCompanyType(Masters pobj);
        CommonResponse updateComanyType(Masters pobj);
    }
    public class MasterService : IMasterService
    {
        public CommonResponse insertCompanyType(Masters pobj)
        {
            pobj.OpCode = 11;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,
                   
                };
            }
           
            pobj.DS.Tables[0].TableName = "CompanyType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            //List<Masters> masters = JsonConvert.DeserializeObject<List<Masters>>(json);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse showCompanyType(Masters pobj)
        {
            pobj.OpCode = 12;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "CompanyType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS
            };
        }

        public CommonResponse updateComanyType(Masters pobj)
        {
            pobj.OpCode = 13;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "CompanyType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS
            };
        }
    }
}
