using SoHoa.Application.AuthorizeServices.Interfaces;
using SoHoa.Domain.IRepositories;
using SoHoa.Domain.Models;
using SoHoa.Infrastructure.Interfaces;
using SoHoa.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Infrastructure.Persistence.Repositories
{
    public class NguoiDungRepository : EFRepository<NguoiDung>, INguoiDungRespository
    {
        public NguoiDungRepository(DbSoHoaContext context, ICurrentUserService currentUserService, IDateTime dateTime):base(context,currentUserService,dateTime)
        {

        }
        
    }
}
