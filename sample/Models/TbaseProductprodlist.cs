using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProductprodlist
    {
        public long ProductProdListId { get; set; }
        public long? ProductProdListProdListCode { get; set; }
        public long? ProductProdListProductCode { get; set; }
        public sbyte? ProductProdListMode { get; set; }
        public sbyte? ProductProdListSyncState { get; set; }
        public string ProductProdListVarParamA { get; set; }
        public string ProductProdListVarParamB { get; set; }
        public long? ProductProdListIntParamA { get; set; }
        public long? ProductProdListIntParamB { get; set; }
        public double? ProductProdListFloatParamA { get; set; }
        public double? ProductProdListFloatParamB { get; set; }
    }
}
