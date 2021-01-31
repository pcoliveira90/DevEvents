using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class Event
   {
      public int id { get; set; }


      public string title { get; set; }

      public string description { get; set; }

      public bool active { get; set; }

      public DateTime dateStart { get; set; }

      public DateTime dateEnd { get; set; }

      public DateTime dateRegister { get; set; }
   }
}
