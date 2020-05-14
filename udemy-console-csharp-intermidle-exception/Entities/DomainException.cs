using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_console_csharp_intermidle_exception.Entities
{
    class DomainException : ApplicationException
    {
        public DomainException(String message) : base(message)
        {
        }
    }
}
