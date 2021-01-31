using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Entities
{
   public class Event
   {
      public int id { get; set; }

      public int idCategory { get; set; }

      public Category category { get; set; }

      public int idUser { get; set; }

      public User user { get; set; }

      public string title { get; set; }

      public string description { get; set; }

      public bool active { get; set; }

      public DateTime dateStart { get; set; }

      public DateTime dateEnd { get; set; }

      public DateTime dateRegister { get; set; }


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
