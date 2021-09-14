using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpReturngood
    {
        public long ReturnGoodsId { get; set; }
        public long ReturnGoodsTableNo { get; set; }
        public long? ReturnGoodsEcstoreCode { get; set; }
        public string ReturnGoodsCname { get; set; }
        public string ReturnGoodsCphone { get; set; }
        public string ReturnGoodsAddress { get; set; }
        public DateTime? ReturnGoodsArrivalDate { get; set; }
        public DateTime ReturnGoodsInsertDate { get; set; }
        public sbyte ReturnGoodsState { get; set; }
        public string ReturnGoodsVarParamA { get; set; }
        public string ReturnGoodsVarParamB { get; set; }
        public long? ReturnGoodsIntParamA { get; set; }
        public long? ReturnGoodsIntParamB { get; set; }
        public double? ReturnGoodsFloatParamA { get; set; }
        public double? ReturnGoodsFloatParamB { get; set; }
    }
}
