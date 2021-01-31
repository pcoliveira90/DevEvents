using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class User
   {
      private int id { get; set; }

      private string username { get; set; }

      private DateTime birthDate { get; set; }

      private string email { get; set; }

      private DateTime dateRegister { get; set; }

      private bool active { get; set; }

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
