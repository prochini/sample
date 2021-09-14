using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProductimg
    {
        public long ProductImgId { get; set; }
        public long ProductImgProductCode { get; set; }
        public string ProductImgImgUrl { get; set; }
        public sbyte ProductImgIsAffiliated { get; set; }
        public string ProductImgExplain { get; set; }
        public sbyte ProductImgState { get; set; }
        public sbyte? ProductImgSyncState { get; set; }
        public string ProductImgVarParamA { get; set; }
        public string ProductImgVarParamB { get; set; }
        public long? ProductImgIntParamA { get; set; }
        public long? ProductImgIntParamB { get; set; }
        public double? ProductImgFloatParamA { get; set; }
        public double? ProductImgFloatParamB { get; set; }
    }
}
