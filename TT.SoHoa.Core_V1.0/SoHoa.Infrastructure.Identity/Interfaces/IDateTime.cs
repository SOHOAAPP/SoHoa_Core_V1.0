using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Infrastructure.Interfaces
{
    public interface IDateTime
    {
        //Provide the current datetime on server
        DateTime Now { get; }
    }
}
