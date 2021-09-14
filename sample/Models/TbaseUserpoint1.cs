using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserpoint1
    {
        public long UserPointId { get; set; }
        public long UserPointUserInfoCode { get; set; }
        public string UserPointText { get; set; }
        public string UserPointSubText { get; set; }
        public double UserPointRegQuantity { get; set; }
        public double UserPointAddQuantity { get; set; }
        public double UserPointAmountQuantity { get; set; }
        public DateTime? UserPointLimitDate { get; set; }
        public DateTime UserPointDate { get; set; }
        public sbyte UserPointState { get; set; }
        public string UserPointVarParamA { get; set; }
        public string UserPointVarParamB { get; set; }
        public long? UserPointIntParamA { get; set; }
        public long? UserPointIntParamB { get; set; }
        public double? UserPointFloatParamA { get; set; }
        public double? UserPointFloatParamB { get; set; }
        public short UserPointType { get; set; }
        public double? UserPointDeductQuantity { get; set; }
        public DateTime? UserPointActiveDate { get; set; }
    }
}
