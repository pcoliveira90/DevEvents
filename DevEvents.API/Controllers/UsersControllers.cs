using DevEvents.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Controllers
{
   [Route("api/[controller]")]
   public class UsersControllers : ControllerBase
   {
      [HttpGet]
      public IActionResult Get()
      {
         return Ok();
      }

      [HttpGet("{id}")]
      public IActionResult Get(int id)
      {
         return Ok();
      }

      [HttpDelete("{id}")]
      public IActionResult Delete(int id)
      {
         return Ok();
      }

      [HttpPost]
      public IActionResult Insert([FromBody] User obj)
      {
         return Ok();
      }

      [HttpPut("{id}")]
      public IActionResult Update(int id, [FromBody] User obj)
      {
         return NoContent();
      }
   }
}
