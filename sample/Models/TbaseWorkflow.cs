using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseWorkflow
    {
        public long WorkflowId { get; set; }
        public string WorkflowName { get; set; }
        public sbyte WorkflowState { get; set; }
        public string WorkflowMemo { get; set; }
        public sbyte? WorkflowSyncState { get; set; }
        public string WorkflowVarParamA { get; set; }
        public string WorkflowVarParamB { get; set; }
        public long? WorkflowIntParamA { get; set; }
        public long? WorkflowIntParamB { get; set; }
        public double? WorkflowFloatParamA { get; set; }
        public double? WorkflowFloatParamB { get; set; }
    }
}
