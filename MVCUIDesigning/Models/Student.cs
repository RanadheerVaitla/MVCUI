﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUIDesigning.Models
{
    public class Student
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public double Fees { get; set; }
        public string Address { get; set; }
    }
}