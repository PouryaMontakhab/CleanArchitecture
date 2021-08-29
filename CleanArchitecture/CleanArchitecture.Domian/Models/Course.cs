using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domian.Models
{
    public class Course
    {
        public Course()
        {
            this.UniqueId = Guid.NewGuid();
        }
        [Key]
        public Guid UniqueId { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
