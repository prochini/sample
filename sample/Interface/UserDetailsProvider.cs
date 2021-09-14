using maneger.Interfaces;
using sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Interface
{
    public abstract class UserDetailsProvider
    {
        public abstract Task<UserDetails> GetUserDetails(string loginId);

    }
}
