using AutoMapper;
using Firebase.Entities.Models;
using Firebase.Repository.Abstract;
using Firebase.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Services.Concrete
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeDTO> GetEmployee()
        {
            var employee = _unitOfWork.EmployeeRepository.Get();
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>(employee);
        }
    }
}
