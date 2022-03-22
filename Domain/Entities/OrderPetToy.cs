using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderPetToy
    {
        
        public Guid OrdersId { get; set; }
        public Guid PetToysId { get; set; }

        public virtual Order Order { get; set; }
        public virtual PetToy PetToys { get; set; } 
    }
}
