using RentalMovie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.Entities.DTOs
{
    public class MovieDetailDto:IDto
    {
        public string MovieTitle { get; set; }
        public String MovieDescription { get; set; }
        public string MovieImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
