using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public string Title{get;set;}

        public string Mobile{get;set;}
    }
}