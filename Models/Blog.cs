using System;
using System.ComponentModel.DataAnnotations;


namespace myspace.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
        public string Content { get; set; }
        public string Pic { get; set; }
        public string Writer { get; set; }
        public string Type { get; set; }
    }
}