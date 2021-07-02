using Microsoft.EntityFrameworkCore;
using SoHoa.Domain.Common;
using SoHoa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoHoa.Infrastructure.Persistence.Context.Interfaces
{
    public interface IDbSoHoaContext : IDisposable
    {
        DbSet<NguoiDung> NguoiDung { get; set; }
        DbSet<T> DbSet<T>() where T : Entity;
    }
}
