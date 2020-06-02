using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public DateTime Deadline { get; set; }
        public bool Done { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
