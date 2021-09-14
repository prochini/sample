using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpVreimburse
    {
        public long VreimburseId { get; set; }
        public long VreimburseTableNo { get; set; }
        public double VreimburseTax { get; set; }
        public double VreimburseNoTax { get; set; }
        public double VreimburseAmount { get; set; }
        public string VreimburseInvoice { get; set; }
        public DateTime? VreimburseInvDate { get; set; }
        public string VreimburseInvImg { get; set; }
        public string VreimburseRemitImg { get; set; }
        public long VreimbursePayType { get; set; }
        public string VreimbursePayInfo { get; set; }
        public sbyte VreimburseTradeCommit { get; set; }
        public sbyte VreimburseIsTransferFile { get; set; }
        public DateTime? VreimburseDownloadDate { get; set; }
        public DateTime? VreimburseCheckoutDate { get; set; }
        public DateTime? VreimburseExpTransferDate { get; set; }
        public DateTime? VreimburseRemitDate { get; set; }
        public string VreimburseRemitFile { get; set; }
        public short VreimburseComGroupNo { get; set; }
        public sbyte VreimburseState { get; set; }
        public DateTime VreimburseInsertDate { get; set; }
        public string VreimburseVarParamA { get; set; }
        public string VreimburseVarParamB { get; set; }
        public string VreimburseVarParamC { get; set; }
        public long? VreimburseIntParamA { get; set; }
        public long? VreimburseIntParamB { get; set; }
        public long? VreimburseIntParamC { get; set; }
        public double? VreimburseFloatParamA { get; set; }
        public double? VreimburseFloatParamB { get; set; }
        public double? VreimburseFloatParamC { get; set; }
    }
}
