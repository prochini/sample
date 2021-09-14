using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappReftable
    {
        public long RefTableId { get; set; }
        public long RefTableTableTypeCode { get; set; }
        public long RefTableMapTableTypeCode { get; set; }
        public string RefTableMapTableTypeName { get; set; }
        public string RefTableSql { get; set; }
        public string RefTableShippingState { get; set; }
        public string RefTableDeliveryState { get; set; }
        public string RefTableRevenueState { get; set; }
        public string RefTableActuallyPaidState { get; set; }
        public string RefTablePaymentState { get; set; }
        public string RefTableIsLock { get; set; }
        public DateTime RefTableDate { get; set; }
        public sbyte RefTableState { get; set; }
        public sbyte? RefTableSyncState { get; set; }
        public string RefTableVarParamA { get; set; }
        public string RefTableVarParamB { get; set; }
        public long? RefTableIntParamA { get; set; }
        public long? RefTableIntParamB { get; set; }
        public double? RefTableFloatParamA { get; set; }
        public double? RefTableFloatParamB { get; set; }
    }
}
