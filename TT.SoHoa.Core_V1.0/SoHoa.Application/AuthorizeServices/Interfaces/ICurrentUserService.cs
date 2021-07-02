using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Application.AuthorizeServices.Interfaces
{
    public interface ICurrentUserService
    {
        string UserName { get; }
        bool IsAuthenticated { get; }
    }
}
