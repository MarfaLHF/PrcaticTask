using System.ComponentModel.DataAnnotations.Schema;

namespace PrcaticTask.Models
{
    public class Model
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("model_name")]
        public string ModelName { get; set; }

        [Column("active_status")]
        public byte ActiveStatus { get; set; }

        [Column("brand_id")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
