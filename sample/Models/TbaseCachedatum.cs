using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseCachedatum
    {
        public long CacheDataId { get; set; }
        public long CacheDataBeactionCode { get; set; }
        public short? CacheDataBeoperCode { get; set; }
        public long CacheDataFeactionCode { get; set; }
        public sbyte? CacheDataSuccess { get; set; }
        public string CacheDataErrMessage { get; set; }
        public DateTime? CacheDataModifyDate { get; set; }
        public DateTime CacheDataDate { get; set; }
        public short CacheDataTemplateState { get; set; }
        public sbyte CacheDataState { get; set; }
        public sbyte? CacheDataSyncState { get; set; }
        public string CacheDataVarParamA { get; set; }
        public string CacheDataVarParamB { get; set; }
        public long? CacheDataIntParamA { get; set; }
        public long? CacheDataIntParamB { get; set; }
        public double? CacheDataFloatParamA { get; set; }
        public double? CacheDataFloatParamB { get; set; }
    }
}
