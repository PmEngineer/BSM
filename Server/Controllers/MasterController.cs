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
        [Consumes("application/x-www-form-urlencoded")]
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
        [HttpGet("updateCompanyType")]
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
        [HttpGet("deleteCompanyType")]
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
        [HttpGet("getCompanyTypeById")]
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
        [HttpGet("updateCompany")]
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
        [HttpGet("deleteCompany")]
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
        [HttpGet("insertCompany")]
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
        [HttpGet("getCompanyById")]
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
        [HttpGet("updateCategory")]
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
        [HttpGet("deleteCategory")]
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
        [HttpGet("insertCategory")]
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
        [HttpGet("getCategoryById")]
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
    }
}
