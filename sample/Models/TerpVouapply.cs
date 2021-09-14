using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpVouapply
    {
        public long VouApplyId { get; set; }
        public long VouApplyTableNo { get; set; }
        public short VouApplyCategoryType { get; set; }
        public string VouApplyUseage { get; set; }
        public string VouApplyRunTime { get; set; }
        public DateTime? VouApplyActiveDate { get; set; }
        public double? VouApplyUserAmount { get; set; }
        public double? VouApplyVouAmount { get; set; }
        public DateTime VouApplyInsertDate { get; set; }
        public sbyte VouApplyValidState { get; set; }
        public sbyte VouApplyState { get; set; }
        public string VouApplyVarParamA { get; set; }
        public string VouApplyVarParamB { get; set; }
        public long? VouApplyIntParamA { get; set; }
        public long? VouApplyIntParamB { get; set; }
        public double? VouApplyFloatParamA { get; set; }
        public double? VouApplyFloatParamB { get; set; }
    }
}
