using SoHoa.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SoHoa.Infrastructure.Common
{
    public class ServerDateTime : IDateTime
    {
        const int TimeZone = 7;
        private CultureInfo cultureInfo = new CultureInfo("vi-VN");
        public DateTime Now => Convert.ToDateTime(DateTime.Now, cultureInfo);
    }
}
