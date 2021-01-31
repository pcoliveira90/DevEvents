using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class Subscription
   {
      public int id { get; set; }

      public int idUser { get; set; }

      public int idCategory { get; set; }

   
      public Subscription()
      {
      }

      public Subscription(int id, int idUser, int idCategory)
      {
         this.id = id;
         this.idUser = idUser;
         this.idCategory = idCategory;
      }

      public override bool Equals(object obj)
      {
         return obj is Subscription subscription &&
                id == subscription.id &&
                idUser == subscription.idUser &&
                idCategory == subscription.idCategory;
      }

      public override int GetHashCode()
      {
         return HashCode.Combine(id, idUser, idCategory);
      }
   }
}
