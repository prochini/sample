using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebTravel
    {
        public long TravelId { get; set; }
        public long TravelCode { get; set; }
        public string TravelName { get; set; }
        public string TravelImg { get; set; }
        public string TravelTitle { get; set; }
        public string TravelSubTitle { get; set; }
        public string TravelUrl { get; set; }
        public sbyte TravelState { get; set; }
        public sbyte? TravelSyncState { get; set; }
        public string TravelVarParamA { get; set; }
        public string TravelVarParamB { get; set; }
        public long? TravelIntParamA { get; set; }
        public long? TravelIntParamB { get; set; }
        public double? TravelFloatParamA { get; set; }
        public double? TravelFloatParamB { get; set; }
        public string TravelLocalTitle { get; set; }
        public string TravelUrltarget { get; set; }
        public sbyte TravelTemplateState { get; set; }
    }
}
