using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Domain.Exceptions
{
    public class EntityException : Exception
    {
        public EntityException(string message) : base(message)
        {

        }
    }
}
