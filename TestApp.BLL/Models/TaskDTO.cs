﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.BLL.Models
{
    public class TaskDTO: BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}