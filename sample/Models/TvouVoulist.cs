using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoulist
    {
        public long VouListId { get; set; }
        public long VouListUpVouListCode { get; set; }
        public long VouListCode { get; set; }
        public string VouListName { get; set; }
        public long VouListLayNo { get; set; }
        public sbyte VouListAttribute { get; set; }
        public string VouListPicUrl1 { get; set; }
        public string VouListPicUrl2 { get; set; }
        public string VouListPicUrl3 { get; set; }
        public string VouListPicUrl4 { get; set; }
        public string VouListPicUrl5 { get; set; }
        public sbyte? VouListTemplateState { get; set; }
        public sbyte VouListState { get; set; }
        public string VouListMemo { get; set; }
        public sbyte? VouListSyncState { get; set; }
        public string VouListVarParamA { get; set; }
        public string VouListVarParamB { get; set; }
        public long? VouListIntParamA { get; set; }
        public long? VouListIntParamB { get; set; }
        public double? VouListFloatParamA { get; set; }
        public double? VouListFloatParamB { get; set; }
    }
}
