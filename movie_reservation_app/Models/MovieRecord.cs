using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_reservation_app.Models
{
    [Table("Movies")]
    public class MovieRecord
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PlacesAvailable { get; set; }
        public int PlacesReserved { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        [ForeignKey("GenreType")]
        public int GenreTypeId { get; set; }
    }
}
