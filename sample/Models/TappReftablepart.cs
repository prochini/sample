using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappReftablepart
    {
        public long RefTablePartId { get; set; }
        public long RefTablePartRefTableId { get; set; }
        public long RefTablePartDealTypeCode { get; set; }
        public long RefTablePartMapDealTypeCode { get; set; }
        public long RefTablePartMapDealStateCode { get; set; }
        public DateTime RefTablePartDate { get; set; }
        public sbyte RefTablePartState { get; set; }
        public sbyte? RefTablePartSyncState { get; set; }
        public string RefTablePartVarParamA { get; set; }
        public string RefTablePartVarParamB { get; set; }
        public long? RefTablePartIntParamA { get; set; }
        public long? RefTablePartIntParamB { get; set; }
        public double? RefTablePartFloatParamA { get; set; }
        public double? RefTablePartFloatParamB { get; set; }
    }
}
