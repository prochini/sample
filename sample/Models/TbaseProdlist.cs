using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProdlist
    {
        public long ProdListId { get; set; }
        public long ProdListUpProdListCode { get; set; }
        public long ProdListCode { get; set; }
        public string ProdListName { get; set; }
        public long ProdListLayNo { get; set; }
        public sbyte ProdListAttribute { get; set; }
        public string ProdListPicUrl1 { get; set; }
        public string ProdListPicUrl2 { get; set; }
        public string ProdListPicUrl3 { get; set; }
        public string ProdListPicUrl4 { get; set; }
        public string ProdListPicUrl5 { get; set; }
        public sbyte? ProdListTemplateState { get; set; }
        public sbyte ProdListState { get; set; }
        public string ProdListMemo { get; set; }
        public sbyte? ProdListSyncState { get; set; }
        public string ProdListVarParamA { get; set; }
        public string ProdListVarParamB { get; set; }
        public long? ProdListIntParamA { get; set; }
        public long? ProdListIntParamB { get; set; }
        public double? ProdListFloatParamA { get; set; }
        public double? ProdListFloatParamB { get; set; }
    }
}
