using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappUserloginstate
    {
        public long UserLoginStateId { get; set; }
        public short? UserLoginStateType { get; set; }
        public long UserLoginStateUserInfoCode { get; set; }
        public long? UserLoginStateUserDeviceCode { get; set; }
        public DateTime? UserLoginStateLogInTime { get; set; }
        public DateTime? UserLoginStateLogOutTime { get; set; }
        public string UserLoginStateIp { get; set; }
        public short UserLoginStateOnlineState { get; set; }
        public sbyte? UserLoginStateSyncState { get; set; }
        public string UserLoginStateVarParamA { get; set; }
        public string UserLoginStateVarParamB { get; set; }
        public long? UserLoginStateIntParamA { get; set; }
        public long? UserLoginStateIntParamB { get; set; }
        public double? UserLoginStateFloatParamA { get; set; }
        public double? UserLoginStateFloatParamB { get; set; }
        public short? UserLoginStateThirdType { get; set; }
    }
}
