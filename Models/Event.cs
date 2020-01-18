using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hafta2.Models
{
    public class Event
    {
        public string Name { get; internal set; }
        public Guid Id { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime CreatedAt { get; internal set; }
        public DateTime FinishDate { get; internal set; }
        public string Address { get; internal set; }
        public bool IsFree { get; internal set; }
        public double Price { get; internal set; }
        public string Subject { get; internal set; }
        public string Desc { get; internal set; }
    }
}
