using System;

namespace dev_3
{
    class InvalidFormatException : Exception
    {
        public override string Message => "Input string must be either only latin or only russian symbols";
    }
}