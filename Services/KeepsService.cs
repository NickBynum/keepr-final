using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
    public class KeepsService
    {
        private readonly KeepsRepository _repo;
        public KeepsService(KeepsRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Keep> Get()
        {
            return _repo.Get();
        }

        public Keep Create(Keep newKeep)
        {
            return _repo.Create(newKeep);
        }

        public Keep GetById(int id)
        {
            Keep foundKeep = _repo.GetById(id);
            if (foundKeep == null)
            {
                throw new Exception("Invalid Id");
            }
            return foundKeep;
        }
        internal string Delete(int id, string userId)
        {
            Keep foundKeep = _repo.GetById(id);
            if (foundKeep.UserId != userId)
            {
                throw new Exception("This isn't yours to delete!");
            }
            if (_repo.Delete(id, userId))
            {
                return "Successfully Deleted";
            }
            throw new Exception("error");
        }

    }
}