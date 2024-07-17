using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PhoneManager(IPhoneDal phoneDal) : IPhoneManager
    {
        private readonly IPhoneDal _phoneDal = phoneDal;

        public void Add(Phone phone)
        {
        if(phone.Price >=2000)
            {
                _phoneDal.Add(phone);
            }
        else if(phone.Name.Length>5)
            {
                _phoneDal.Add(phone);
            }
            else
                throw new Exception("Məhsulu əlavə etmək mümkün olmadı ...");
        }
        public void Delete(Phone phone)
        {
            _phoneDal.Delete(phone);
        }

        public List<Phone> GetAll()
        {
            return _phoneDal.GetAll();
        }

        public void Update(Phone phone)
        {
            _phoneDal.Update(phone);
        }
    }
}
