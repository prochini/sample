using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebTravelprodlist
    {
        public ulong TravelProdListId { get; set; }
        public long? TravelProdListProdListCode { get; set; }
        public long? TravelProdListTravelCode { get; set; }
        public sbyte? TravelProdListSyncState { get; set; }
        public string TravelProdListVarParamA { get; set; }
        public string TravelProdListVarParamB { get; set; }
        public long? TravelProdListIntParamA { get; set; }
        public long? TravelProdListIntParamB { get; set; }
        public double? TravelProdListFloatParamA { get; set; }
        public double? TravelProdListFloatParamB { get; set; }
    }
}
