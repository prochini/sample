using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebImessage
    {
        public long ImessageId { get; set; }
        public long ImessageMsgCategoryCode { get; set; }
        public long? ImessageEcstoreCode { get; set; }
        public long? ImessageUserInfoCode { get; set; }
        public short ImessageMode { get; set; }
        public long ImessageShareCount { get; set; }
        public long ImessageClickCount { get; set; }
        public string ImessageTitle { get; set; }
        public string ImessageDesc { get; set; }
        public string ImessageBody { get; set; }
        public string ImessageBigImg { get; set; }
        public string ImessageSmallImg { get; set; }
        public DateTime ImessageReleaseDate { get; set; }
        public DateTime ImessageEndDate { get; set; }
        public DateTime ImessageInsertDate { get; set; }
        public long ImessageSort { get; set; }
        public sbyte ImessageState { get; set; }
        public sbyte? ImessageSyncState { get; set; }
        public string ImessageVarParamA { get; set; }
        public string ImessageVarParamB { get; set; }
        public long? ImessageIntParamA { get; set; }
        public long? ImessageIntParamB { get; set; }
        public double? ImessageFloatParamA { get; set; }
        public double? ImessageFloatParamB { get; set; }
        public long? ImessageOrderNo { get; set; }
        public long? ImessageCode { get; set; }
        public sbyte? ImessageIsShowCta { get; set; }
        public sbyte ImessageIsShow { get; set; }
    }
}
