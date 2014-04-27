using System.Collections.Generic;
using System.Security;

namespace Proxy
{
    public class SomeServiceProxy : ISomeService
    {
        private readonly ISomeService _someService;

        public SomeServiceProxy()
        {
            _someService = new SomeService();
        }

        public List<string> GetStrings()
        {
            // Just for fun, let's use this proxy for permissions.
            ValidateAccess("GetStrings");

            return _someService.GetStrings();
        }

        private void ValidateAccess(string methodName)
        {
            // Here, we could call some other class to get whether 
            // the user has access to this whatever method they're accessing.
            // We could throw an exception if they dont have access.
            throw new SecurityException("You don't have access to this action.");
        }
    }
}
