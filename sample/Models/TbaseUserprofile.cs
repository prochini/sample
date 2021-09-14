using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserprofile
    {
        public long UserProfileId { get; set; }
        public long? UserProfileUserInfoCode { get; set; }
        public long? UserProfileCompanyCode { get; set; }
        public string UserProfileName { get; set; }
        public short? UserProfileBloodType { get; set; }
        public double? UserProfileHeight { get; set; }
        public double? UserProfileWeight { get; set; }
        public string UserProfileMobile { get; set; }
        public string UserProfileEmail { get; set; }
        public short? UserProfileDriveType { get; set; }
        public short? UserProfileSex { get; set; }
        public long? UserProfileInnerDegree { get; set; }
        public long? UserProfileOutDegree { get; set; }
        public long? UserProfileDepart { get; set; }
        public DateTime? UserProfileBirthday { get; set; }
        public string UserProfileIdno { get; set; }
        public short? UserProfileMarriage { get; set; }
        public long? UserProfileCountry { get; set; }
        public long? UserProfileCity { get; set; }
        public long? UserProfileCityArea { get; set; }
        public string UserProfileAddress { get; set; }
        public string UserProfileTel { get; set; }
        public long? UserProfileLocalCountry { get; set; }
        public long? UserProfileLocalCity { get; set; }
        public long? UserProfileLocalCityArea { get; set; }
        public string UserProfileLocalAddress { get; set; }
        public string UserProfileLocalTel { get; set; }
        public string UserProfileLinkman { get; set; }
        public string UserProfileLinkTel { get; set; }
        public string UserProfileLinkRelationship { get; set; }
        public string UserProfileHealthState { get; set; }
        public DateTime? UserProfileCheckHealthDate { get; set; }
        public short? UserProfileHiredType { get; set; }
        public long? UserProfileDutyAgent { get; set; }
        public long? UserProfileSupervisor { get; set; }
        public DateTime? UserProfileInsertDate { get; set; }
        public DateTime? UserProfileUpdateDate { get; set; }
        public sbyte UserProfileState { get; set; }
        public sbyte? UserProfileSyncState { get; set; }
        public string UserProfileVarParamA { get; set; }
        public string UserProfileVarParamB { get; set; }
        public long? UserProfileIntParamA { get; set; }
        public long? UserProfileIntParamB { get; set; }
        public double? UserProfileFloatParamA { get; set; }
        public double? UserProfileFloatParamB { get; set; }
    }
}
