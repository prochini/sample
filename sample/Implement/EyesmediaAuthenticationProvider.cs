using sample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Implement
{
    public class EyesmediaAuthenticationProvider : AuthenticationProvider
    {
        public override Authentication authenticate(Authentication Authentications)
        {
            var jwt = new JWTAuthentication("123");
            return jwt;
        }
    }
}
