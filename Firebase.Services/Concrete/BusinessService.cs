using AutoMapper;
using Firebase.Entities.DBContext;
using Firebase.Repository.Abstract;
using Firebase.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Services.Concrete
{
    public class BusinessService: IBusinessService
    {
        private EmployeeService employeeService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BusinessService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #region RepositoryClasses
        public EmployeeService EmployeeService
        {
            get
            {
                if (this.employeeService == null)
                    this.employeeService = new EmployeeService(_unitOfWork, _mapper);
                return employeeService;
            }
        }

        #endregion RepositoryClasses
    }
}
