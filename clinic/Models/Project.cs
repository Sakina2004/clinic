using System.ComponentModel;
using clinic.Models.Common;

namespace clinic.Models
{
    public class Project:BaseEntity
    {
        public string  ImagePath { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
