using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoCoolShop.BusniessLogic.Interfaces
{
    interface ICRUD<T>
    {
        void Create(T entity);
        T Get(int id);
        IEnumerable GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
