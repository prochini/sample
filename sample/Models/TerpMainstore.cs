using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpMainstore
    {
        public long MainStoreId { get; set; }
        public long MainStoreTableNo { get; set; }
        public long MainStoreCompanyCode { get; set; }
        public long? MainStoreContractStoreCode { get; set; }
        public string MainStoreCompanyName { get; set; }
        public string MainStoreContactName { get; set; }
        public string MainStoreContactTel { get; set; }
        public string MainStoreContactCell { get; set; }
        public DateTime MainStoreInsertDate { get; set; }
        public sbyte MainStoreState { get; set; }
        public sbyte? MainStoreSyncState { get; set; }
        public string MainStoreVarParamA { get; set; }
        public string MainStoreVarParamB { get; set; }
        public string MainStoreVarParamC { get; set; }
        public long? MainStoreIntParamA { get; set; }
        public long? MainStoreIntParamB { get; set; }
        public long? MainStoreIntParamC { get; set; }
        public double? MainStoreFloatParamA { get; set; }
        public double? MainStoreFloatParamB { get; set; }
        public double? MainStoreFloatParamC { get; set; }
    }
}
