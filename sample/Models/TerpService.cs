using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpService
    {
        public long ServicesId { get; set; }
        public long ServicesTableNo { get; set; }
        public long ServicesOrderTableNo { get; set; }
        public long ServicesEcstoreCode { get; set; }
        public long ServicesUserInfoCode { get; set; }
        public string ServicesCname { get; set; }
        public string ServicesCphone { get; set; }
        public string ServicesAddress { get; set; }
        public string ServicesEmail { get; set; }
        public string ServicesOtherMsg { get; set; }
        public short ServicesReason { get; set; }
        public sbyte ServicesHandleState { get; set; }
        public sbyte ServicesState { get; set; }
        public DateTime ServicesInsertDate { get; set; }
        public string ServicesVarParamA { get; set; }
        public string ServicesVarParamB { get; set; }
        public long? ServicesIntParamA { get; set; }
        public long? ServicesIntParamB { get; set; }
        public double? ServicesFloatParamA { get; set; }
        public double? ServicesFloatParamB { get; set; }
    }
}
