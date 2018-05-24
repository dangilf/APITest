using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain.Core.Models
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Key { get; set; }
        public virtual List<Task> Tasks { get; set; }
        
    }
}
