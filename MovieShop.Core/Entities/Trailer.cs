using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.Entities
{
    public class Trailer
    {
        //One Movie can have multiple trailer
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string TrailerUrl { get; set; }
        public string Name { get; set; }
        //navigation properties of the related entity
        public Movie movie { get; set; }
    }
}
