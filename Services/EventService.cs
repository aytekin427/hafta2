using hafta2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static hafta2.DTOs.EventDtos;

namespace hafta2.Services
{
    public class EventService
    {
        public interface IEventService
        {
            string Add(EventAddDto model);
        }

        public class EventService : IEventService
        {
            private static readonly IList<Event> data = new List<Event>();

            public EventService()
            {
            }

            public static IList<Event> Data => data;

            public string Add(EventAddDto model)
            {
                Event entity = new Event
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow
                };

                entity.Name = model.Name;
                entity.StartDate = model.StartDate;
                entity.FinishDate = model.FinishDate;
                entity.Address = model.Address;
                entity.IsFree = model.IsFree;
                entity.Price = model.Price;
                entity.Subject = model.Subject;
                entity.Desc = model.Desc;

                data.Add(entity);

                return "eklendi.";
            }
        }
    }
}
