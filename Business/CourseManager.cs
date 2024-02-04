using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intro.Entities;
namespace intro.Business
{
    
    public class CourseManager
    {
        private Course[] _courses;
        public CourseManager()
        {   
            _courses = new Course[3];
            _courses[0] = new Course(1, "C#", "C# 8 vs ...", 0);
            _courses[1] = new Course(2, "Python", "Python3 vs ...", 10);
            _courses[2] = new Course(3, "Java", "Java5 vs ...", 20);
          
        }
        public Course[] GetAll(){
            return this._courses;
        }
    }
}