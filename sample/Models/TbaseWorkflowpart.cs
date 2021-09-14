using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseWorkflowpart
    {
        public long WorkflowPartId { get; set; }
        public long WorkflowPartWorkflowId { get; set; }
        public long WorkflowPartDealTypeCode { get; set; }
        public long WorkflowPartDealStateCode { get; set; }
        public long WorkflowPartNextTableTypeCode { get; set; }
        public long WorkflowPartNextDealTypeCode { get; set; }
        public sbyte WorkflowPartIsIgnoreDealer { get; set; }
        public sbyte WorkflowPartDataFlow { get; set; }
        public string WorkflowPartDataFlowColumn { get; set; }
        public sbyte WorkflowPartNotice { get; set; }
        public sbyte WorkflowPartState { get; set; }
        public string WorkflowPartMemo { get; set; }
        public sbyte? WorkflowPartSyncState { get; set; }
        public string WorkflowPartVarParamA { get; set; }
        public string WorkflowPartVarParamB { get; set; }
        public long? WorkflowPartIntParamA { get; set; }
        public long? WorkflowPartIntParamB { get; set; }
        public double? WorkflowPartFloatParamA { get; set; }
        public double? WorkflowPartFloatParamB { get; set; }
    }
}
