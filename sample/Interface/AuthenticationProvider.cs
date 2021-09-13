using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Interface
{
    public abstract class AuthenticationProvider
    {
        public abstract Authentication authenticate(Authentication authentication);
    }
}
