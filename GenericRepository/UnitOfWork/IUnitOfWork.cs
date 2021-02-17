using GenericRepository.Model;
using GenericRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.UnitOfWork
{
    public interface IUnitOfWork 
    {
        void Save();   
    }
}
