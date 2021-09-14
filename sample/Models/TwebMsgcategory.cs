using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebMsgcategory
    {
        public long MsgCategoryId { get; set; }
        public long MsgCategoryCountryCode { get; set; }
        public short MsgCategoryMode { get; set; }
        public long MsgCategoryCode { get; set; }
        public string MsgCategoryName { get; set; }
        public string MsgCategorySmallImg { get; set; }
        public string MsgCategoryBigImg { get; set; }
        public DateTime MsgCategoryReleaseDate { get; set; }
        public DateTime MsgCategoryEndDate { get; set; }
        public DateTime MsgCategoryInsertDate { get; set; }
        public long MsgCategorySort { get; set; }
        public sbyte MsgCategoryState { get; set; }
        public sbyte? MsgCategorySyncState { get; set; }
        public string MsgCategoryVarParamA { get; set; }
        public string MsgCategoryVarParamB { get; set; }
        public long? MsgCategoryIntParamA { get; set; }
        public long? MsgCategoryIntParamB { get; set; }
        public double? MsgCategoryFloatParamA { get; set; }
        public double? MsgCategoryFloatParamB { get; set; }
        public sbyte MsgCategoryIsShow { get; set; }
    }
}
