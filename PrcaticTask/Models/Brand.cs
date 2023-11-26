using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace PrcaticTask.Models
{
    public class Brand
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("brand_name")]
        public string BrandName { get; set; }

        [Column("active_status")]
        public byte ActiveStatus { get; set; }

        public List<Model> Models { get; set; }
    }
}
