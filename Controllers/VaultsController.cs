using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Keepr.Models;
using Keepr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keepr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VaultsController : ControllerBase
    {
        private readonly VaultsService _vs;
        public VaultsController(VaultsService vs)
        {
            _vs = vs;
        }
        //NOTE path is https://localhost:5001/api/vaults
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Vault>> Get()
        {
            try
            {
                return Ok(_vs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            };
        }
    }
}