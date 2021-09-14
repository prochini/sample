using sample.Interface;
using sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Implement
{
    public  class AuthenticationManager
    {
        private AuthenticationProvider authenticationProvider;
        private UserDetailsProvider userDetailProvider;

        public AuthenticationManager(AuthenticationProvider authenticationProvider, UserDetailsProvider userDetailProvider)
        {
            this.authenticationProvider = authenticationProvider;
            this.userDetailProvider = userDetailProvider;
        }

        public  Authentication authenticate(Authentication authentication)
        {
            string id = "";
            authenticationProvider.authenticate(authentication);
            var res = userDetailProvider.GetUserDetails(id);
            return res.Result;
        }

    }
}
