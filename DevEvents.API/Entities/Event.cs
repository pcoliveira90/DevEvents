using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class Event
   {
      private int id { get; set; }

      private int idCategory { get; set; }

      private Category category { get; set; }

      private int idUser { get; set; }

      private User user { get; set; }

      private string title { get; set; }

      private string description { get; set; }

      private bool active { get; set; }

      private DateTime dateStart { get; set; }

      private DateTime dateEnd { get; set; }

      private DateTime dateRegister { get; set; }

      public Event()
      {
      }

      public Event(int id, string title, string description, bool active, DateTime dateStart, DateTime dateEnd, DateTime dateRegister)
      {
         this.id = id;
         this.title = title;
         this.description = description;
         this.active = active;
         this.dateStart = dateStart;
         this.dateEnd = dateEnd;
         this.dateRegister = dateRegister;
      }

      public override bool Equals(object obj)
      {
         return obj is Event @event &&
                id == @event.id;
      }

      public override int GetHashCode()
      {
         return HashCode.Combine(id);
      }
   }
}
