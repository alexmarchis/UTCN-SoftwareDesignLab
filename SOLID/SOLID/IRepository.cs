using System.Collections;
using System.Collections.Generic;

namespace SOLID
{
    interface IRepository
    {
        IEnumerable<T> GetAll<T>();
    }
}
