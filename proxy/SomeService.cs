using System.Collections.Generic;

namespace Proxy
{
    public class SomeService : ISomeService
    {
        public List<string> GetStrings()
        {
            return new List<string>
                {
                    "String1",
                    "String2",
                    "String3"
                };
        }
    }
}
