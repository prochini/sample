using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebTravelattr
    {
        public long TravelAttrId { get; set; }
        public long TravelAttrTravelCode { get; set; }
        public sbyte TravelAttrAttributeType { get; set; }
        public long TravelAttrAttributeCode { get; set; }
        public string TravelAttrAttributeName { get; set; }
        public long TravelAttrAttributeValueCode { get; set; }
        public string TravelAttrAttributeValueName { get; set; }
        public sbyte? TravelAttrSyncState { get; set; }
        public string TravelAttrVarParamA { get; set; }
        public string TravelAttrVarParamB { get; set; }
        public long? TravelAttrIntParamA { get; set; }
        public long? TravelAttrIntParamB { get; set; }
        public double? TravelAttrFloatParamA { get; set; }
        public double? TravelAttrFloatParamB { get; set; }
        public sbyte? TravelAttrIsShow { get; set; }
    }
}
