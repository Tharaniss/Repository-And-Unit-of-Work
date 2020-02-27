using Firebase.Entities.DBContext;
using Firebase.Entities.Models;
using Firebase.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Repository.Concrete
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private GenericRepository<Employee> employeeRepository;
        private FirebaseDBContext context;
        public UnitOfWork(FirebaseDBContext context)
        {
            this.context = context;
        }

        #region RepositoryClasses
        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                    this.employeeRepository = new GenericRepository<Employee>(context);
                return employeeRepository;
            }
        }

        #endregion RepositoryClasses
        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}
