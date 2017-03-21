using System;
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
    public class OwnerService : IOwnerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OwnerService(IUnitOfWork iUnitOfWork)
        {
            AutoMapperConfiguration.Configure();
            _unitOfWork = iUnitOfWork;
        }

        public IEnumerable<OwnerDTO> GetAllOwners()
        {
            return Mapper.Map<IEnumerable<OwnerDTO>>(_unitOfWork.OwnerRepository.Get());
        }

        public void AddOwner(OwnerDTO owner)
        {
            _unitOfWork.OwnerRepository.Create(Mapper.Map<Owner>(owner));
            _unitOfWork.Save();
        }

        public OwnerDTO GetOwnerById(int id)
        {
            var owner = _unitOfWork.OwnerRepository.Get(id);
            if (owner == null)
            {
                throw new NotFoundException();
            }
            return Mapper.Map<OwnerDTO>(owner);
        }

        public void DeleteOwner(int id)
        {
            var owner = _unitOfWork.OwnerRepository.Get(id);
            _unitOfWork.OwnerRepository.Delete(owner);
            _unitOfWork.Save();
        }
    }
}
