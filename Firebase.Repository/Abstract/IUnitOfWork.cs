using Firebase.Entities.Models;
using Firebase.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Repository.Abstract
{
    public interface IUnitOfWork
    {
        GenericRepository<Employee> EmployeeRepository { get; }
    }
}
