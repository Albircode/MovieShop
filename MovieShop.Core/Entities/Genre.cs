using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieShop.Core.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(24)]
        public string Name { get; set; }
        public ICollection<Movie> Movie { get; set; }

    }
}
