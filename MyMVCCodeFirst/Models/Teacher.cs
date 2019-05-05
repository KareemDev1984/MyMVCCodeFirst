using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCCodeFirst.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
      
        public ICollection<School> schools { get; set; }

        public Teacher()
        {
            schools = new List<School>();
        }
    }
}