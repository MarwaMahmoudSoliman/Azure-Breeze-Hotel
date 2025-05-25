using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Managers
{
    

        public interface IManager<T>
        {
            bool Add(T item);
            bool Delete(long id);
            List<T> GetAll();
            T GetByID(long id);
            bool Update(T item);
        }
    }


