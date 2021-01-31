using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
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



      public User()
      {
      }

      public User(int id, string username, DateTime birthDate, string email, DateTime dateRegister, bool active)
      {
         this.id = id;
         this.username = username;
         this.birthDate = birthDate;
         this.email = email;
         this.dateRegister = dateRegister;
         this.active = active;
      }

      public override bool Equals(object obj)
      {
         return obj is User user &&
                id == user.id;
      }

      public override int GetHashCode()
      {
         return HashCode.Combine(id);
      }
   }
}
