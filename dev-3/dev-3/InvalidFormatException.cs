using System;
/// <summary>
/// Custom exception class used by transliterator
/// </summary>
namespace dev_3
{
    public class InvalidFormatException : Exception
    {
        public override string Message => "Input string must be either only latin or only russian symbols";
    }
}