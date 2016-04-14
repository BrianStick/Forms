using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forms.Models
{
    public class Task 
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completion { get; set; }

        public Task(string name,string description,bool completion)
        {
            Name = name;
            Description = description;
            Completion = completion;
        }

        public Task()
        {

        }
    }
}