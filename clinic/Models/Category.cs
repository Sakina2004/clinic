using clinic.Models.Common;

namespace clinic.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Project>? Projects { get; set; }
    }
}
