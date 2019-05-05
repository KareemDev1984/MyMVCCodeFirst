using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCCodeFirst.Models
{
    public class School
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers{ get; set; }
        public School()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

    



    }
}