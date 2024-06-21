using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    interface IDb<T, K>
    {
        void Create(T entity);
        T Read(K key, bool useNavigationalProperties = false, bool isReadOnlyTrue = true);
        List<T> ReadAll(bool useNavigationalProperties = false, bool isReadOnlyTrue = true);
        void Update(T entity, bool useNavigationalProperties = false);
        void Delete(K key);
    }
}
