using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class User
   {
      public int id { get; set; }

      public string username { get; set; }

      public DateTime birthDate { get; set; }

      public string email { get; set; }

      public DateTime dateRegister { get; set; }

      public bool active { get; set; }

   }
}
