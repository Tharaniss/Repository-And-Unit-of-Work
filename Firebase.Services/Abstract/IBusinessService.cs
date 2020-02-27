using Firebase.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Services.Abstract
{
    public interface IBusinessService
    {
        EmployeeService EmployeeService { get; }
    }
}
