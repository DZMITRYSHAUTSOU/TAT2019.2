using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_3
{
    class InvalidFormatException : Exception
    {
        public override string Message => "Input string must be either only latin or only russian symbols.Ё is not supported";
    }
}
