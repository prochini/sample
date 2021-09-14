using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserinfo
    {
        public long UserInfoId { get; set; }
        public short UserInfoCountryCode { get; set; }
        public short UserInfoType { get; set; }
        public long UserInfoCode { get; set; }
        public short? UserInfoAccountCty { get; set; }
        public string UserInfoAccount { get; set; }
        public long? UserInfoCompanyCode { get; set; }
        public long? UserInfoEcstoreCode { get; set; }
        public string UserInfoPassword { get; set; }
        public short UserInfoGroupNo { get; set; }
        public string UserInfoName { get; set; }
        public string UserInfoExtCode { get; set; }
        public double? UserInfoPoint { get; set; }
        public double? UserInfoVirtualPoint { get; set; }
        public DateTime UserInfoInsertDate { get; set; }
        public DateTime UserInfoUpdateDate { get; set; }
        public DateTime UserInfoExpireDate { get; set; }
        public sbyte UserInfoState { get; set; }
        public sbyte? UserInfoSyncState { get; set; }
        public string UserInfoVarParamA { get; set; }
        public string UserInfoVarParamB { get; set; }
        public long? UserInfoIntParamA { get; set; }
        public long? UserInfoIntParamB { get; set; }
        public double? UserInfoFloatParamA { get; set; }
        public double? UserInfoFloatParamB { get; set; }
        public sbyte? UserInfoRegisterDevice { get; set; }
        public string UserInfoUuid { get; set; }
    }
}
