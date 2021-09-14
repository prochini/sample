using sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maneger.Interfaces
{
    public interface Imember
    {
        Task<UserDetails> GetMember(string id);

        //Task<(ICollection<Member> MemberList, int Total)> GetMemberList(string search, string city, string district,
        //  int page, int limit);
    }
}
