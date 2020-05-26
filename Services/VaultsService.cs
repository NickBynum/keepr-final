using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class VaultsService
  {
    private readonly KeepsRepository _repo;
    public VaultsService(KeepsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Keep> Get()
    {
      return _repo.Get();
    }
    internal IEnumerable<Keep> GetByUserId(string userId)
    {
      return _repo.GetKeepsByUserId(userId);
    }
  }
}