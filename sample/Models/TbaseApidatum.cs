using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseApidatum
    {
        public long ApidataId { get; set; }
        public long ApidataPartnerCode { get; set; }
        public long ApidataApicode { get; set; }
        public string ApidataJsonData { get; set; }
        public DateTime ApidataDate { get; set; }
        public sbyte ApidataTemplateState { get; set; }
        public sbyte ApidataState { get; set; }
        public sbyte? ApidataSyncState { get; set; }
        public string ApidataVarParamA { get; set; }
        public string ApidataVarParamB { get; set; }
        public long? ApidataIntParamA { get; set; }
        public long? ApidataIntParamB { get; set; }
        public double? ApidataFloatParamA { get; set; }
        public double? ApidataFloatParamB { get; set; }
        public string ApidataStoreId { get; set; }
    }
}
