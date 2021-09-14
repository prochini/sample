using maneger.Interfaces;
using sample.Interface;

using sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Implement
{
    public class MobiiUserDetailsProvider : UserDetailsProvider
    {
        public Imember _Imember;

        public MobiiUserDetailsProvider(Imember Imember) 
        {
            _Imember = Imember;
        }

        public override Task<UserDetails> GetUserDetails(string loginId)
        {
            var id = "e75d02af-a285-49e8-a9fe-05809a557051";
            var res = _Imember.GetMember(id);
            return res;
        }
    }
}
