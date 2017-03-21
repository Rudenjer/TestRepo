using System.Collections.Generic;
using AutoMapper;
using TestProject.BusinessLogicLayer.DTO;
using TestProject.BusinessLogicLayer.Exceptions;
using TestProject.BusinessLogicLayer.Interfaces;
using TestProject.BusinessLogicLayer.Mappers;
using TestProject.DataAccessLayer.Entities;
using TestProject.DataAccessLayer.Interfaces;

namespace TestProject.BusinessLogicLayer.Services
{
    public class PetService: IPetService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PetService(IUnitOfWork iUnitOfWork)
        {
            AutoMapperConfiguration.Configure();
            _unitOfWork = iUnitOfWork;
        }

        public IEnumerable<PetDTO> GetAllPets()
        {
            return Mapper.Map<IEnumerable<PetDTO>>(_unitOfWork.PetRepository.Get());
        }

        public void AddPet(PetDTO pet)
        {
            _unitOfWork.PetRepository.Create(Mapper.Map<Pet>(pet));
            _unitOfWork.Save();
        }

        public PetDTO GetPetById(int id)
        {
            var pet = _unitOfWork.PetRepository.Get(id);
            if (pet == null)
            {
                throw new NotFoundException();
            }
            return Mapper.Map<PetDTO>(pet);
        }

        public void DeletePet(int id)
        {
            var pet = _unitOfWork.PetRepository.Get(id);
            _unitOfWork.PetRepository.Delete(pet);
            _unitOfWork.Save();
        }
    }
}

