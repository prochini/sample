using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpPointpart
    {
        public ulong PointPartId { get; set; }
        public long PointPartPointTableNo { get; set; }
        public long PointPartUserInfoCode { get; set; }
        public string PointPartUserInfoUuid { get; set; }
        public string PointPartUserInfoName { get; set; }
        public sbyte PointPartUserState { get; set; }
        public sbyte PointPartValidState { get; set; }
        public sbyte PointPartState { get; set; }
        public sbyte? PointPartSyncState { get; set; }
        public string PointPartVarParamA { get; set; }
        public string PointPartVarParamB { get; set; }
        public long? PointPartIntParamA { get; set; }
        public long? PointPartIntParamB { get; set; }
        public double? PointPartFloatParamA { get; set; }
        public double? PointPartFloatParamB { get; set; }
    }
}
