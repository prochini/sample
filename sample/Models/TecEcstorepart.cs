using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstorepart
    {
        public long EcstorePartId { get; set; }
        public long EcstorePartEcstoreCode { get; set; }
        public string EcstorePartTicketInfo { get; set; }
        public string EcstorePartHistoricType { get; set; }
        public string EcstorePartHistoricPost { get; set; }
        public string EcstorePartStar { get; set; }
        public short? EcstorePartRooms { get; set; }
        public sbyte EcstorePartState { get; set; }
        public sbyte? EcstorePartSyncState { get; set; }
        public string EcstorePartVarParamA { get; set; }
        public string EcstorePartVarParamB { get; set; }
        public long? EcstorePartIntParamA { get; set; }
        public long? EcstorePartIntParamB { get; set; }
        public double? EcstorePartFloatParamA { get; set; }
        public double? EcstorePartFloatParamB { get; set; }
    }
}
