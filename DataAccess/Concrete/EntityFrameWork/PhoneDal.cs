using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class PhoneDal : BaseRepository<Phone, ContextDB>, IPhoneDal
    {
        public List<Phone> CheckById()
        {
            throw new NotImplementedException();
        }
    }
}
