using DataAccess.EFCore.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace WebAPI.Services
{
    public class PetToyService : IPetToyService
    {
        private readonly PetToyRepository _petToyRepository;
        public static List<PetToy> OrderedToys = new List<PetToy>();
        public PetToyService(PetToyRepository petToyRepository)
        {
            _petToyRepository = petToyRepository;
        }

        public PetToy GetById(Guid id)
        {
            var toy = _petToyRepository.GetById(id);
            if(toy != null)
            {
                return toy;
            }
            else
            {
                throw new Exception();
            }               
        }
        public IEnumerable<PetToy> GetAll()
        {
            var allToys = _petToyRepository.GetAll();
            if(allToys != null)
            {
                return _petToyRepository.GetAll();
            }
            else
            {
                throw new Exception();
            }
         
        }
        public PetToy Add(PetToy entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Description) || string.IsNullOrWhiteSpace(entity.Material) || string.IsNullOrWhiteSpace(entity.Name) ||
                string.IsNullOrWhiteSpace(entity.Material) || entity.Price == 0 || Double.IsNegative(entity.Price))
            {
                throw new Exception();
            }
            else
            {
                _petToyRepository.Add(entity);
                return entity;
            }
        }
        public PetToy Remove(Guid id)
        {
            var toy = GetById(id);
            if(toy != null)
            {
                _petToyRepository.Remove(toy);
                return toy;
            }
            else
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception();
            }
            
        }
        public PetToy Update(Guid id, PetToy entity)
        {
            if (!Guid.Equals(id, entity.Id))
            {
                throw new Exception();
            }
            if (id == Guid.Empty || entity.Id == Guid.Empty || string.IsNullOrWhiteSpace(entity.Description) || string.IsNullOrWhiteSpace(entity.Material) ||
                string.IsNullOrWhiteSpace(entity.Name) || entity.Price == 0 || Double.IsNegative(entity.Price))
            {
                throw new Exception();
            }
            _petToyRepository.Update(id, entity);
            return entity;
        }
        public PetToy FilterByName(string search)
        {
            var toy = _petToyRepository.FilterByName(search);
            if (toy != null)
            {
                return toy;
            }
            else
            {
                throw new Exception();
            }
        }
        public PetToy FilterByDescription(string search)
        {
            var toy = _petToyRepository.FilterByDescription(search);
            if (toy != null)
            {
                return toy;
            }
            else
            {
                throw new Exception();
            }
        }
        public List<PetToy> AddToyToList(string search)
        {
            var toy = FilterByName(search);
            if(toy != null)
                OrderedToys.Add(toy);
            return OrderedToys;
        }
    }
}
