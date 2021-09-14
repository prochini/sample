

using maneger.Interfaces;
using Microsoft.EntityFrameworkCore;
using sample.Models;
using sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sample.Implement
{
    public class MemberImplement: Imember
    {
        private readonly tAFPDBContext _db;

        public MemberImplement(tAFPDBContext db)
        {
            _db = db;
        }        

        public async Task<UserDetails> GetMember(string id)
        {
            var UserInfo = new UserDetails();
            UserInfo.MobiiUser = await _db.MobiiUsers.Where(x => x.UserId == id).FirstOrDefaultAsync();
            UserInfo.TbaseUserinfo = await _db.TbaseUserinfos.Where(x => x.UserInfoId == UserInfo.MobiiUser.TbaseUserinfoId).FirstOrDefaultAsync();
            UserInfo.TbaseUserprofile = await _db.TbaseUserprofiles.Where(x => x.UserProfileUserInfoCode == UserInfo.TbaseUserinfo.UserInfoCode).FirstOrDefaultAsync();
            UserInfo.TbaseUserfavourite1 = await _db.TbaseUserfavourite1s.Where(x => x.UserFavouriteUserInfoCode == UserInfo.TbaseUserinfo.UserInfoCode).ToListAsync();
            return UserInfo;
        }

        
    }
}
