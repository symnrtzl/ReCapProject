using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentCarDetailsDto : IDto
    {
        public int RentalsId { get; set; }
        public string CarId { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set;}
    }
}
