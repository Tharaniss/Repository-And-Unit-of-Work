using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Services.Abstract
{
    interface IGenericService<IData, IEnity, IRepository> where IData : class where IEnity : class where IRepository : class
    {
    }
}
