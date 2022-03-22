using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } 
        public string CustomerFirstname { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCreditCard { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderPetToy> PetToys { get; set; }

    }
}
