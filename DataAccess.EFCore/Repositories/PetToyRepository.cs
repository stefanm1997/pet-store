using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class PetToyRepository : GenericRepository<PetToy>, IPetToyRepository
    {
        public PetToyRepository(ApplicationContext context) : base(context)
        { 
        }
        public PetToy FilterByName(string search) 
        {
            return _context.PetToys.Where(x => x.Name.Contains(search)).FirstOrDefault();
        }
        public PetToy FilterByDescription(string search)
        {
            return _context.PetToys.Where(x => x.Description.Contains(search)).FirstOrDefault();
        }
    }
}
