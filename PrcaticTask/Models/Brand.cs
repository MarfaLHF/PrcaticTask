using System.Reflection;

namespace PrcaticTask.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public List<Model> Models { get; set; }
    }
}
