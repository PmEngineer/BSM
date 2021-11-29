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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpPost("updateCompanyType")
            [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult updateCompanyType(Masters pobj)
        {
            try
            {
                var response = masterService.updateCompanyType(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showCompany")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult showCompany()
        {
            try
            {
                var response = masterService.showCompany();

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult showCategory()
        {
            try
            {
                var response = masterService.showCategory();

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showSubCategory")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult showSubCategory()
        {
            try
            {
                var response = masterService.showSubCategory();

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showBillType")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult showBillType()
        {
            try
            {
                var response = masterService.showBillType();

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
        [HttpGet("showFinancialYear")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult showFinancialYear()
        {
            try
            {
                var response = masterService.showFinancialYear();

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
        public IActionResult updateFinvancialYear(Masters pobj)
        {
            try
            {
                var response = masterService.updateFinvancialYear(pobj);

                if (response == null)
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
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
                    return BadRequest(new { message = "Data Not Insert" });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
    }
}
