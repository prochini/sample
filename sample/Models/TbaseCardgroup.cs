using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseCardgroup
    {
        public ulong CardGroupId { get; set; }
        public long CardGroupCode { get; set; }
        public short CardGroupType { get; set; }
        public string CardGroupName { get; set; }
        public string CardGroupImg { get; set; }
        public short CardGroupTotal { get; set; }
        public DateTime CardGroupInsertDate { get; set; }
        public DateTime CardGroupUpdateDate { get; set; }
        public sbyte CardGroupState { get; set; }
        public sbyte? CardGroupSyncState { get; set; }
        public string CardGroupVarParamA { get; set; }
        public string CardGroupVarParamB { get; set; }
        public long? CardGroupIntParamA { get; set; }
        public long? CardGroupIntParamB { get; set; }
        public double? CardGroupFloatParamA { get; set; }
        public double? CardGroupFloatParamB { get; set; }
        public string CardGroupThumbnail { get; set; }
        public string CardGroupLink { get; set; }
    }
}
