using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstoreexttype
    {
        public long EcstoreExtTypeId { get; set; }
        public long EcstoreExtTypeEcstoreCode { get; set; }
        public long EcstoreExtTypePartnerCode { get; set; }
        public short EcstoreExtTypeType { get; set; }
        public string EcstoreExtTypeExtCode { get; set; }
        public DateTime? EcstoreExtTypeDate { get; set; }
        public sbyte EcstoreExtTypeState { get; set; }
        public sbyte? EcstoreExtTypeSyncState { get; set; }
        public string EcstoreExtTypeVarParamA { get; set; }
        public string EcstoreExtTypeVarParamB { get; set; }
        public long? EcstoreExtTypeIntParamA { get; set; }
        public long? EcstoreExtTypeIntParamB { get; set; }
        public double? EcstoreExtTypeFloatParamA { get; set; }
        public double? EcstoreExtTypeFloatParamB { get; set; }
        public string EcstoreExtTypeExtName { get; set; }
    }
}
