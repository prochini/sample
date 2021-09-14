using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebAdimg
    {
        public long AdimgId { get; set; }
        public short AdimgType { get; set; }
        public long AdimgEcstoreCode { get; set; }
        public long AdimgAdcode { get; set; }
        public string AdimgImg { get; set; }
        public string AdimgVideoUrl { get; set; }
        public string AdimgTitle { get; set; }
        public string AdimgUrl { get; set; }
        public DateTime AdimgReleaseDate { get; set; }
        public DateTime AdimgEndDate { get; set; }
        public sbyte AdimgState { get; set; }
        public sbyte? AdimgSyncState { get; set; }
        public string AdimgVarParamA { get; set; }
        public string AdimgVarParamB { get; set; }
        public long? AdimgIntParamA { get; set; }
        public long? AdimgIntParamB { get; set; }
        public double? AdimgFloatParamA { get; set; }
        public double? AdimgFloatParamB { get; set; }
        public string AdimgName { get; set; }
        public string AdimgSubTitle { get; set; }
        public string AdimgUrltarget { get; set; }
        public long AdimgSort { get; set; }
        public sbyte? AdimgAppUrltarget { get; set; }
    }
}
