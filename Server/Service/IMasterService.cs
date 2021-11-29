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
        //CompanyType
        CommonResponse insertCompanyType(Masters pobj);
        CommonResponse showCompanyType();
        CommonResponse updateCompanyType(Masters pobj);

        CommonResponse deleteCompanyType(Masters pobj);
        CommonResponse getCompanyTypeById(Masters pobj);
        //Company
        CommonResponse showCompany();
        CommonResponse updateCompany(Masters pobj);
        CommonResponse deleteCompany(Masters pobj);
        CommonResponse insertCompany(Masters pobj);
        CommonResponse getCompanyById(Masters pobj);

    }
    public class MasterService : IMasterService
    {
        public CommonResponse deleteCompany(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse deleteCompanyType(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse getCompanyById(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse getCompanyTypeById(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse insertCompany(Masters pobj)
        {
            pobj.OpCode = 19;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Company";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            //List<Masters> masters = JsonConvert.DeserializeObject<List<Masters>>(json);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

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

        public CommonResponse showCompany()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 16;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Company";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse showCompanyType()
        {
            Masters pobj = new Masters();
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
                responseValue = json
            };
        }

        public CommonResponse updateCompanyType(Masters pobj)
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

        public CommonResponse updateCompany(Masters pobj)
        {
            pobj.OpCode = 17;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Company";
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
