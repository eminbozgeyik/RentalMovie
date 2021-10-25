using RentalMovie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.Entities.Concrete
{
    public class Movie:IEntity
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public String MovieDescription { get; set; }
        public string MovieImageUrl { get; set; }
        public bool IsPopular { get; set; }
        public DateTime DatePublished { get; set; }
        public int CategoryId { get; set; }
    }
}
