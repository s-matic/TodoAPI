﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
