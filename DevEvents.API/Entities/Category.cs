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

      public Category()
      {
      }

      public Category(int id, string description, bool active)
      {
         this.id = id;
         this.description = description;
         this.active = active;
      }

      public override bool Equals(object obj)
      {
         return obj is Category category &&
                id == category.id;
      }

      public override int GetHashCode()
      {
         return HashCode.Combine(id);
      }
   }
}
