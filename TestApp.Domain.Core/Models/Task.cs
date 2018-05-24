using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain.Core.Models
{
    public class Task: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }


    }
}
