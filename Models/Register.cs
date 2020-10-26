using System;
using System.ComponentModel.DataAnnotations;

namespace myspace.Models
{
    public class Resgiter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int Gender {get;set;}
        public int City {get;set;}
        public string Commutermode {get;set;}
        public string Comment {get;set;}
        public bool Terms{get;set;}
        
    }
}