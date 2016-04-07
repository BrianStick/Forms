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
        public string Discription { get; set; }
        public bool Completion { get; set; }

        public Task(string name,string discription,bool completion)
        {
            Name = name;
            Discription = discription;
            Completion = completion;
        }

        public Task()
        {

        }
    }
}