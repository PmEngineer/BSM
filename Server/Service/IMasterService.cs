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
        //Brand
        CommonResponse showBrand();
        CommonResponse updateBrand(Masters pobj);
        CommonResponse deleteBrand(Masters pobj);
        CommonResponse insertBrand(Masters pobj);
        CommonResponse getBrandById(Masters pobj);
        //Category
        CommonResponse showCategory();
        CommonResponse updateCategory(Masters pobj);
        CommonResponse deleteCategory(Masters pobj);
        CommonResponse insertCategory(Masters pobj);
        CommonResponse getCategoryById(Masters pobj);
        //SubCategory
        CommonResponse showSubCategory();
        CommonResponse updateSubCategory(Masters pobj);
        CommonResponse deleteSubCategory(Masters pobj);
        CommonResponse insertSubCategory(Masters pobj);
        CommonResponse getSubCategoryById(Masters pobj);
        //BillType
        CommonResponse showBillType();
        CommonResponse updateBillType(Masters pobj);
        CommonResponse deleteBillType(Masters pobj);
        CommonResponse insertBillType(Masters pobj);
        CommonResponse getBillTypeById(Masters pobj);
        //FinancialYear
        CommonResponse showFinancialYear();
        CommonResponse updateFinancialYear(Masters pobj);
        CommonResponse deleteFinancialYear(Masters pobj);
        CommonResponse insertFinancialYear(Masters pobj);
        CommonResponse getFinancialYearById(Masters pobj);


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

        public CommonResponse showBrand()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 18;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Brand";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse updateBrand(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "Brand";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS
            };
        }

        public CommonResponse deleteBrand(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse insertBrand(Masters pobj)
        {
            pobj.OpCode = 20;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Brand";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse getBrandById(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse showCategory()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 23;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse updateCategory(Masters pobj)
        {
            pobj.OpCode = 26;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse deleteCategory(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse insertCategory(Masters pobj)
        {
            pobj.OpCode = 25;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse getCategoryById(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse showSubCategory()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 28;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubCategory";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse updateSubCategory(Masters pobj)
        {
            pobj.OpCode = 30;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubCategory";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse deleteSubCategory(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse insertSubCategory(Masters pobj)
        {
            pobj.OpCode = 29;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubCategory";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse getSubCategoryById(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse showBillType()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 33;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "BillType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse updateBillType(Masters pobj)
        {
            pobj.OpCode = 34;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "BillType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse deleteBillType(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse insertBillType(Masters pobj)
        {
            pobj.OpCode = 37;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "BillType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse getBillTypeById(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse showFinancialYear()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 39;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "FinancialYear";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse updateFinancialYear(Masters pobj)
        {
            pobj.OpCode = 41;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "FinancialYear";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse deleteFinancialYear(Masters pobj)
        {
            throw new NotImplementedException();
        }

        public CommonResponse insertFinancialYear(Masters pobj)
        {
            pobj.OpCode = 38;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "FinancialYear";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = json
            };
        }

        public CommonResponse getFinancialYearById(Masters pobj)
        {
            throw new NotImplementedException();
        }
    }
}
