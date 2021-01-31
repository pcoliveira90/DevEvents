using DevEvents.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Controllers
{
   [Route("api/[controller]")]
   public class EventsController : ControllerBase
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
      public IActionResult Insert([FromBody] Event obj)
      {
         return Ok();
      }

      [HttpPut("{id}")]
      public IActionResult Update(int id, [FromBody] Event obj)
      {
         return NoContent();
      }

      [HttpPost("{id}")]
      public IActionResult InsertSubscription(int id, [FromBody] Subscription obj)
      {
         return NoContent();
      }
   }
}
