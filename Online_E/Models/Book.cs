﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_E.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}