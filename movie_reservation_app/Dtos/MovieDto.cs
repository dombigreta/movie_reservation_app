using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_reservation_app.Dtos
{
    public class MovieDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PlacesAvailable { get; set; }
        public int PlacesReserved { get; set; }
        public int GenreTypeId { get; set; }
        public string Genre { get; set; }
    }
}
