using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class Category
   {
      public int id { get; set; }

      public string description { get; set; }

      public bool active { get; set; }
   }
}
