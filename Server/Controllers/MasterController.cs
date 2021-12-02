using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSM.Server.Service;
using BSM.Shared.Model;
namespace BSM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : Controller
    {
        private IMasterService masterService;
        public MasterController(IMasterService _MasterService)
        {
            masterService = _MasterService;
        }




        [HttpPost("insertCompanyType")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertCompanyType([FromForm] Masters model)
        {
            try
            {
                var response = masterService.insertCompanyType(model);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet("showCompanyType")]
        public IActionResult showCompanyType()
        {
            try
            {
                var response = masterService.showCompanyType();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateCompanyType")]
            [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateCompanyType(Masters pobj)
        {
            try
            {
                var response = masterService.updateCompanyType(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteCompanyType")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteCompanyType(Masters pobj)
        {
            try
            {
                var response = masterService.deleteCompanyType(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getCompanyTypeById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getCompanyTypeById(Masters pobj)
        {
            try
            {
                var response = masterService.getCompanyTypeById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showCompany")]
        
        public IActionResult showCompany()
        {
            try
            {
                var response = masterService.showCompany();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateCompany")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateCompany(Masters pobj)
        {
            try
            {
                var response = masterService.updateCompany(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteCompany")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteCompany(Masters pobj)
        {
            try
            {
                var response = masterService.deleteCompany(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertCompany")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertCompany(Masters pobj)
        {
            try
            {
                var response = masterService.insertCompany(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getCompanyById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getCompanyById(Masters pobj)
        {
            try
            {
                var response = masterService.getCompanyById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showCategory")]
        
        public IActionResult showCategory()
        {
            try
            {
                var response = masterService.showCategory();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateCategory(Masters pobj)
        {
            try
            {
                var response = masterService.updateCategory(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteCategory(Masters pobj)
        {
            try
            {
                var response = masterService.deleteCategory(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertCategory(Masters pobj)
        {
            try
            {
                var response = masterService.insertCategory(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getCategoryById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getCategoryById(Masters pobj)
        {
            try
            {
                var response = masterService.getCategoryById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showSubCategory")]
        
        public IActionResult showSubCategory()
        {
            try
            {
                var response = masterService.showSubCategory();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateSubCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateSubCategory(Masters pobj)
        {
            try
            {
                var response = masterService.updateSubCategory(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteSubCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteSubCategory(Masters pobj)
        {
            try
            {
                var response = masterService.deleteSubCategory(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertSubCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertSubCategory(Masters pobj)
        {
            try
            {
                var response = masterService.insertSubCategory(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getSubCategoryById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getSubCategoryById(Masters pobj)
        {
            try
            {
                var response = masterService.getSubCategoryById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showBillType")]
       
        public IActionResult showBillType()
        {
            try
            {
                var response = masterService.showBillType();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateBillType")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateBillType(Masters pobj)
        {
            try
            {
                var response = masterService.updateBillType(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteBillType")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteBillType(Masters pobj)
        {
            try
            {
                var response = masterService.deleteBillType(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertBillType")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertBillType(Masters pobj)
        {
            try
            {
                var response = masterService.insertBillType(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getBillTypeById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getBillTypeById(Masters pobj)
        {
            try
            {
                var response = masterService.getBillTypeById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showFinancialYear")]
       
        public IActionResult showFinancialYear()
        {
            try
            {
                var response = masterService.showFinancialYear();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateFinvancialYear")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateFinancialYear(Masters pobj)
        {
            try
            {
                var response = masterService.updateFinancialYear(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteFinancialYear")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteFinancialYear(Masters pobj)
        {
            try
            {
                var response = masterService.deleteFinancialYear(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertFinancialYear")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertFinancialYear(Masters pobj)
        {
            try
            {
                var response = masterService.insertFinancialYear(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getFinancialYearById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getFinancialYearById(Masters pobj)
        {
            try
            {
                var response = masterService.getFinancialYearById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showMenuMaster")]
        \
        public IActionResult showMenuMaster()
        {
            try
            {
                var response = masterService.showMenuMaster();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateMenuMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateMenuMaster(Masters pobj)
        {
            try
            {
                var response = masterService.updateMenuMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteMenuMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteMenuMaster(Masters pobj)
        {
            try
            {
                var response = masterService.deleteMenuMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertMenuMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertMenuMaster(Masters pobj)
        {
            try
            {
                var response = masterService.insertMenuMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getMenuMasterById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getMenuMasterById(Masters pobj)
        {
            try
            {
                var response = masterService.getMenuMasterById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showSubMenuMaster")]
        
        public IActionResult showSubMenuMaster()
        {
            try
            {
                var response = masterService.showSubMenuMaster();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateSubMenuMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateSubMenuMaster(Masters pobj)
        {
            try
            {
                var response = masterService.updateSubMenuMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteSubMenuMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteSubMenuMaster(Masters pobj)
        {
            try
            {
                var response = masterService.deleteSubMenuMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertSubMenuMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertSubMenuMaster(Masters pobj)
        {
            try
            {
                var response = masterService.insertSubMenuMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getSubMenuMasterById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getSubMenuMasterById(Masters pobj)
        {
            try
            {
                var response = masterService.getSubMenuMasterById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("showRoleMaster")]
        
        public IActionResult showRoleMaster()
        {
            try
            {
                var response = masterService.showRoleMaster();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateRoleMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateRoleMaster(Masters pobj)
        {
            try
            {
                var response = masterService.updateRoleMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteRoleMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteRoleMaster(Masters pobj)
        {
            try
            {
                var response = masterService.deleteRoleMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertRoleMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertRoleMaster(Masters pobj)
        {
            try
            {
                var response = masterService.insertRoleMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getRoleMasterById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getRoleMasterById(Masters pobj)
        {
            try
            {
                var response = masterService.getRoleMasterById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("showUnitMaster")]
       
        public IActionResult showUnitMaster()
        {
            try
            {
                var response = masterService.showUnitMaster();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateUnitMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateUnitMaster(Masters pobj)
        {
            try
            {
                var response = masterService.updateUnitMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteUnitMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteUnitMaster(Masters pobj)
        {
            try
            {
                var response = masterService.deleteUnitMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertUnitMaster")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertUnitMaster(Masters pobj)
        {
            try
            {
                var response = masterService.insertUnitMaster(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getUnitMasterById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getUnitMasterById(Masters pobj)
        {
            try
            {
                var response = masterService.getUnitMasterById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("showWarehouses")]

        public IActionResult showWarehouses()
        {
            try
            {
                var response = masterService.showWarehouses();

                if (response == null)
                    return BadRequest(new { message = "Data Not Show" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateWarehouses")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateWarehouses(Masters pobj)
        {
            try
            {
                var response = masterService.updateWarehouses(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Update" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("deleteWarehouses")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult deleteWarehouses(Masters pobj)
        {
            try
            {
                var response = masterService.deleteWarehouses(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Delete" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("insertWarehouses")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult insertWarehouses(Masters pobj)
        {
            try
            {
                var response = masterService.insertWarehouses(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("getWarehousesById")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult getWarehousesById(Masters pobj)
        {
            try
            {
                var response = masterService.getWarehousesById(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Get" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
