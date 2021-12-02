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

        //MenuMaster
        CommonResponse showMenuMaster();
        CommonResponse updateMenuMaster(Masters pobj);
        CommonResponse deleteMenuMaster(Masters pobj);
        CommonResponse insertMenuMaster(Masters pobj);
        CommonResponse getMenuMasterById(Masters pobj);
        //SubMenuMaster
        CommonResponse showSubMenuMaster();
        CommonResponse updateSubMenuMaster(Masters pobj);
        CommonResponse deleteSubMenuMaster(Masters pobj);
        CommonResponse insertSubMenuMaster(Masters pobj);
        CommonResponse getSubMenuMasterById(Masters pobj);

        //RoleMaster
        CommonResponse showRoleMaster();
        CommonResponse updateRoleMaster(Masters pobj);
        CommonResponse deleteRoleMaster(Masters pobj);
        CommonResponse insertRoleMaster(Masters pobj);
        CommonResponse getRoleMasterById(Masters pobj);
       
        //UniteMaster
        CommonResponse showUnitMaster();
        CommonResponse updateUnitMaster(Masters pobj);
        CommonResponse deleteUnitMaster(Masters pobj);
        CommonResponse insertUnitMaster(Masters pobj);
        CommonResponse getUnitMasterById(Masters pobj);

        //Warehouses
        CommonResponse showWarehouses();
        CommonResponse updateWarehouses(Masters pobj);
        CommonResponse deleteWarehouses(Masters pobj);
        CommonResponse insertWarehouses(Masters pobj);
        CommonResponse getWarehousesById(Masters pobj);
    }
    public class MasterService : IMasterService
    {
        public CommonResponse deleteCompany(Masters pobj)
        {
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

            pobj.DS.Tables[0].TableName = "Company";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteCompanyType(Masters pobj)
        {
            pobj.OpCode = 14;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getCompanyById(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "Company";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getCompanyTypeById(Masters pobj)
        {
            pobj.OpCode = 15;
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
                responseValue = pobj.DS.Tables[0]
            };
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
                responseValue = pobj.DS.Tables[0]
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
                responseValue = pobj.DS.Tables[0]
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
                responseValue = pobj.DS.Tables[0]
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
                responseValue = pobj.DS.Tables[0]
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showBrand()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 21;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateBrand(Masters pobj)
        {
            pobj.OpCode = 22;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteBrand(Masters pobj)
        {
            pobj.OpCode = 24;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertBrand(Masters pobj)
        {
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

            pobj.DS.Tables[0].TableName = "Brand";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getBrandById(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "Brand";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showCategory()
        {
            Masters pobj = new Masters();
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateCategory(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteCategory(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertCategory(Masters pobj)
        {
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

            pobj.DS.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getCategoryById(Masters pobj)
        {
            pobj.OpCode = 27;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showSubCategory()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 31;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateSubCategory(Masters pobj)
        {
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

            pobj.DS.Tables[0].TableName = "SubCategory";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteSubCategory(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "SubCategory";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertSubCategory(Masters pobj)
        {
            pobj.OpCode = 32;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getSubCategoryById(Masters pobj)
        {
            pobj.OpCode = 35;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showBillType()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 36;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateBillType(Masters pobj)
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteBillType(Masters pobj)
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

            pobj.DS.Tables[0].TableName = "BillType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertBillType(Masters pobj)
        {
            pobj.OpCode = 40;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getBillTypeById(Masters pobj)
        {
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

            pobj.DS.Tables[0].TableName = "BillType";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showFinancialYear()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 45;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateFinancialYear(Masters pobj)
        {
            pobj.OpCode = 44;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteFinancialYear(Masters pobj)
        {
            pobj.OpCode = 43;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertFinancialYear(Masters pobj)
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getFinancialYearById(Masters pobj)
        {
            pobj.OpCode = 42;
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
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showMenuMaster()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 46;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "MenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateMenuMaster(Masters pobj)
        {
            pobj.OpCode = 49;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "MenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteMenuMaster(Masters pobj)
        {
            pobj.OpCode = 48;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "MenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };

        }

        public CommonResponse insertMenuMaster(Masters pobj)
        {
            pobj.OpCode = 47;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "MenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getMenuMasterById(Masters pobj)
        {
            pobj.OpCode = 50;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "MenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        

        public CommonResponse showSubMenuMaster()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 51;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubMenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateSubMenuMaster(Masters pobj)
        {
            pobj.OpCode = 54;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubMenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteSubMenuMaster(Masters pobj)
        {
            pobj.OpCode = 53;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubMenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertSubMenuMaster(Masters pobj)
        {
            pobj.OpCode = 52;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubMenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getSubMenuMasterById(Masters pobj)
        {
            pobj.OpCode = 55;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "SubMenuMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showRoleMaster()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 56;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "RoleMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateRoleMaster(Masters pobj)
        {
            pobj.OpCode = 59;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "RoleMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteRoleMaster(Masters pobj)
        {
            pobj.OpCode = 58;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "RoleMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertRoleMaster(Masters pobj)
        {
            pobj.OpCode = 57;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "RoleMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getRoleMasterById(Masters pobj)
        {
            pobj.OpCode = 60;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "RoleMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showUnitMaster()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 61;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "UnitMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateUnitMaster(Masters pobj)
        {
            pobj.OpCode = 63;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "UnitMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteUnitMaster(Masters pobj)
        {
            pobj.OpCode = 62;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "UnitMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertUnitMaster(Masters pobj)
        {
            pobj.OpCode = 64;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "UnitMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getUnitMasterById(Masters pobj)
        {
            pobj.OpCode = 65;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "UnitMaster";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse showWarehouses()
        {
            Masters pobj = new Masters();
            pobj.OpCode = 66;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Warehouses";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);

            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse updateWarehouses(Masters pobj)
        {
            pobj.OpCode = 68;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Warehouses";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse deleteWarehouses(Masters pobj)
        {
            pobj.OpCode = 67;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Warehouses";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse insertWarehouses(Masters pobj)
        {
            pobj.OpCode = 70;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Warehouses";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }

        public CommonResponse getWarehousesById(Masters pobj)
        {
            pobj.OpCode = 69;
            DalMaster.returnTable(pobj);
            if (pobj.IsException)
            {
                return new CommonResponse()
                {
                    status = 0,
                    message = pobj.ExceptionMessage,

                };
            }

            pobj.DS.Tables[0].TableName = "Warehouses";
            string json = JsonConvert.SerializeObject(pobj.DS, Formatting.None);
            return new CommonResponse()
            {
                status = 1,
                message = "Success",
                responseValue = pobj.DS.Tables[0]
            };
        }
    }
}
