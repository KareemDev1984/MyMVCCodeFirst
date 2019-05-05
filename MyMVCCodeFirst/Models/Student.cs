using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCCodeFirst.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        
       
        
    }
}