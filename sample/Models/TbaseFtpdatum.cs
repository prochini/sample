using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseFtpdatum
    {
        public ulong FtpdataId { get; set; }
        public long FtpdataProjectCode { get; set; }
        public string FtpdataRowData { get; set; }
        public string FtpdataFileName { get; set; }
        public DateTime FtpdataDate { get; set; }
        public sbyte FtpdataTemplateState { get; set; }
        public sbyte FtpdataState { get; set; }
        public sbyte? FtpdataSyncState { get; set; }
        public string FtpdataVarParamA { get; set; }
        public string FtpdataVarParamB { get; set; }
        public long? FtpdataIntParamA { get; set; }
        public long? FtpdataIntParamB { get; set; }
        public double? FtpdataFloatParamA { get; set; }
        public double? FtpdataFloatParamB { get; set; }
    }
}
