using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Institute : Department
    {
        public Institute(string name, string city, string street, string house) : base(name, city, street, house) { }
    }
}
