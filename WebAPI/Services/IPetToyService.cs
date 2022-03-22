using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace WebAPI.Services
{
    public interface IPetToyService
    {
        PetToy GetById(Guid id);
        IEnumerable<PetToy> GetAll();
        PetToy Add(PetToy entity);
        PetToy Remove(Guid id);
        PetToy Update(Guid id, PetToy entity);
        PetToy FilterByName(string search);
        PetToy FilterByDescription(string search);
    }
}
