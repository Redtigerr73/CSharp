using System;

namespace TryCatch2.Exceptions
{
    class IndexZeroException : Exception
    {
        public IndexZeroException(string message) : base(message)
        {
        }
    }
}
