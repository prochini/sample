using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstorepaymentmap
    {
        public long EcstorePaymentMapId { get; set; }
        public long EcstorePaymentMapCompanyCode { get; set; }
        public long EcstorePaymentMapEcstoreCode { get; set; }
        public long EcstorePaymentMapContractStore { get; set; }
        public long EcstorePaymentMapCspaymentId { get; set; }
        public string EcstorePaymentMapCspaymentShowName { get; set; }
        public sbyte EcstorePaymentMapState { get; set; }
        public sbyte? EcstorePaymentMapSyncState { get; set; }
        public string EcstorePaymentMapVarParamA { get; set; }
        public string EcstorePaymentMapVarParamB { get; set; }
        public long? EcstorePaymentMapIntParamA { get; set; }
        public long? EcstorePaymentMapIntParamB { get; set; }
        public double? EcstorePaymentMapFloatParamA { get; set; }
        public double? EcstorePaymentMapFloatParamB { get; set; }
    }
}
