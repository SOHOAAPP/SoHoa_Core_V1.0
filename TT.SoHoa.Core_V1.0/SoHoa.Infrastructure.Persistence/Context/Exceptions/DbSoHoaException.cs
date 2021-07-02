using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Infrastructure.Persistence.Context.Exceptions
{
    public class DbSoHoaException : Exception
    {
        public DbSoHoaException(string message) : base(message)
        {

        }
        public DbSoHoaException(string message,Exception innerException) : base(message,innerException)
        {

        }
        public DbSoHoaException(string sql, object[] parms,Exception innerException) : base("In Db: " + string.Format("Sql: {0} Parms: {1}", (sql ?? "--"),
            (parms != null ? string.Join(",", Array.ConvertAll<object,string>(parms, o => (o ?? "null").ToString())) : "--")), innerException)
        {

        }
    }
}
