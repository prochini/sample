using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpApplyinfopart
    {
        public long ApplyInfoPartId { get; set; }
        public long ApplyInfoPartTableNo { get; set; }
        public long? ApplyInfoPartOtherCode { get; set; }
        public long ApplyInfoPartUserInfoCode { get; set; }
        public string ApplyInfoPartUserInfoUuid { get; set; }
        public string ApplyInfoPartUserInfoName { get; set; }
        public short ApplyInfoPartUserInfoGroupNo { get; set; }
        public sbyte ApplyInfoPartUserState { get; set; }
        public sbyte ApplyInfoPartValidState { get; set; }
        public string ApplyInfoPartValidMsg { get; set; }
        public sbyte ApplyInfoPartState { get; set; }
        public sbyte? ApplyInfoPartSyncState { get; set; }
        public string ApplyInfoPartVarParamA { get; set; }
        public string ApplyInfoPartVarParamB { get; set; }
        public long? ApplyInfoPartIntParamA { get; set; }
        public long? ApplyInfoPartIntParamB { get; set; }
        public double? ApplyInfoPartFloatParamA { get; set; }
        public double? ApplyInfoPartFloatParamB { get; set; }
    }
}
