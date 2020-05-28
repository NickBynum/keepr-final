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
  public class KeepVaultsController : ControllerBase
  {
    private readonly KeepVaultsService _kvs;

    public KeepVaultsController(KeepVaultsService kvs)
    {
      _kvs = kvs;
    }

    [HttpPost]
    public ActionResult<KeepVault> Create([FromBody] KeepVault newKeepVault)
    {
      try
      {
        return Ok(_kvs.Create(newKeepVault));
      }
      catch (System.Exception)
      {

        throw;
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_kvs.Delete(id));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
  }
}