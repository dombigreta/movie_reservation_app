using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace movie_reservation_app.Models
{
    [Table("Reservations")]
    public class ReservationRecord
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNme { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("Movies")]
        public int MovieId { get; set; }
    }
}
