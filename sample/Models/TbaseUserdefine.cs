using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserdefine
    {
        public long UserDefineId { get; set; }
        public long UserDefineChannelId { get; set; }
        public long UserDefineUpUserDefineCode { get; set; }
        public long UserDefineCode { get; set; }
        public string UserDefineName { get; set; }
        public long? UserDefineLayNo { get; set; }
        public sbyte? UserDefineAttribute { get; set; }
        public string UserDefinePicUrl1 { get; set; }
        public string UserDefinePicUrl2 { get; set; }
        public string UserDefinePicUrl3 { get; set; }
        public string UserDefinePicUrl4 { get; set; }
        public string UserDefinePicUrl5 { get; set; }
        public sbyte? UserDefineTemplateState { get; set; }
        public long? UserDefineSort { get; set; }
        public sbyte? UserDefineState { get; set; }
        public string UserDefineMemo { get; set; }
        public sbyte? UserDefineSyncState { get; set; }
        public string UserDefineVarParamA { get; set; }
        public string UserDefineVarParamB { get; set; }
        public long? UserDefineIntParamA { get; set; }
        public long? UserDefineIntParamB { get; set; }
        public double? UserDefineFloatParamA { get; set; }
        public double? UserDefineFloatParamB { get; set; }
        public int? UserDefineProdCount { get; set; }
    }
}
