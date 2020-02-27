using Firebase.Repository.Abstract;
using Firebase.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Services.Concrete
{
    public class GenericService<IData, IEnity, IRepository> : IGenericService<IData, IEnity, IRepository> where IData : class where IEnity : class where IRepository : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public GenericService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        //public IData Get()
        //{
        //    var address = _unitOfWork.EmployeeRepository.Get();
        //    return Mapper.Map<IData, IEnity>(address);
        //}

        //public IEnumerable<IEnity> Get()
        //{
        //    var address = _unitOfWork.EmployeeRepository.Get();
        //    return address;
        //}
    }
}
