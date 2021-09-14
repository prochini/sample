using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class MobiiUser
    {
        public string UserId { get; set; }
        public string IdentityAccessToken { get; set; }
        public string IdentityRefreshToken { get; set; }
        public string UserName { get; set; }
        public string UserAvatar { get; set; }
        public string UserEmail { get; set; }
        public DateTime? UserBday { get; set; }
        public string UserGender { get; set; }
        public long TbaseUserinfoId { get; set; }
        public Guid? CrtUserId { get; set; }
        public string CrtUserName { get; set; }
        public DateTime? CrtDate { get; set; }
        public string MdyUserId { get; set; }
        public string MdyUserName { get; set; }
        public DateTime? MdyDate { get; set; }
    }
}
