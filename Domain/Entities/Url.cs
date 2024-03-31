using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("urls")]
    public class Url
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("link")]
        public string Link { get; set; }
    }
}