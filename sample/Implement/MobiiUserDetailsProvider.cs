using sample.Interface;
using sample.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Implement
{
    public class MobiiUserDetailsProvider : UserDetailsProvider
    {
        public override UserDetails GetUserDetails(string loginId)
        {
            return new UserDetails();
        }
    }
}
