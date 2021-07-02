using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Infrastructure.Interfaces
{
    public interface IStringHelper
    {
        string GetHash(string input);
        string GenerateGigitString(int length);
        string GenerateDigitAndLetterString(int length);
    }
}
