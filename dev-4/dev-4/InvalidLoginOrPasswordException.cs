using System;

namespace dev_4
{
    /// <summary>
    /// Custom exception for invalid login-password combination case
    /// </summary>
    class InvalidLoginOrPasswordException : Exception
    {
        public override string Message => "Invalid login or password.";
    }
}