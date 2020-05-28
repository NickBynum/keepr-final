using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class VaultsService
  {
    private readonly VaultsRepository _repo;
    public VaultsService(VaultsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Vault> Get()
    {
      return _repo.Get();
    }
    internal IEnumerable<Vault> GetByUserId(string userId)
    {
      return _repo.GetVaultsByUserId(userId);
    }
        public Vault Create(Vault newVault)
    {
      return _repo.Create(newVault);
    }

    public Vault GetById(int id)
    {
      Vault foundVault = _repo.GetById(id);
      if (foundVault == null)
      {
        throw new Exception("Invalid Id");
      }
      return foundVault;
    }
        internal string Delete(int id, string userId)
    {
      Vault foundVault = _repo.GetById(id);
      if (foundVault.UserId != userId)
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