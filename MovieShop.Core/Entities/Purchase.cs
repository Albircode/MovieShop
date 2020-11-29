using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.Entities
{
   public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public System.Guid PurchaseNumber { get; set; }
        public decimal TotalNumber { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
