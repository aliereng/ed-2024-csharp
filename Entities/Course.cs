using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro.Entities
{
   
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public Course(int id, string name, string description, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        
    }
}