using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace movie_reservation_app.Models
{
    [Table("GenreType")]
    public class GenreTypeRecord
    {
        [Key]
        public int Id { get; set; }
        public string ResourceKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
