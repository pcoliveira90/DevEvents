using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class Subscription
   {
      private int id { get; set; }

      private int idUser { get; set; }

      private int idCategory { get; set; }

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
