using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProductgiveaway
    {
        public long ProductGiveawayId { get; set; }
        public long ProductGiveawayProductCode { get; set; }
        public long ProductGiveawayGiveawayCode { get; set; }
        public short ProductGiveawayCount { get; set; }
        public sbyte? ProductGiveawaySyncState { get; set; }
        public string ProductGiveawayVarParamA { get; set; }
        public string ProductGiveawayVarParamB { get; set; }
        public long? ProductGiveawayIntParamA { get; set; }
        public long? ProductGiveawayIntParamB { get; set; }
        public double? ProductGiveawayFloatParamA { get; set; }
        public double? ProductGiveawayFloatParamB { get; set; }
    }
}
