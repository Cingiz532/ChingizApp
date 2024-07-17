using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Electronics : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public short Price { get; set; }
        public int Count { get; set; }

    }
}
