using sample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Implement
{
    public class JWTAuthentication: Authentication
    {
        private string jwt;

        public JWTAuthentication(string jwt)
        {
            this.jwt = jwt;
        }

    }
}
