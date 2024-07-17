using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPhoneManager
    {
        void Add(Phone phone);
        void Update(Phone phone);
        void Delete(Phone phone);
        List<Phone> GetAll();

    }
}
