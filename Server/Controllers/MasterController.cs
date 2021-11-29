﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult insertCompanyType( Masters model)
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
    }
}
