using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpPoint
    {
        public ulong PointId { get; set; }
        public long PointTableNo { get; set; }
        public short PointCategoryType { get; set; }
        public string PointText { get; set; }
        public string PointSubText { get; set; }
        public string PointUseage { get; set; }
        public short PointType { get; set; }
        public double PointAddQuantity { get; set; }
        public double? PointUserAmount { get; set; }
        public DateTime? PointActiveDate { get; set; }
        public DateTime PointInsertDate { get; set; }
        public sbyte PointValidState { get; set; }
        public sbyte PointState { get; set; }
        public string PointVarParamA { get; set; }
        public string PointVarParamB { get; set; }
        public long? PointIntParamA { get; set; }
        public long? PointIntParamB { get; set; }
        public double? PointFloatParamA { get; set; }
        public double? PointFloatParamB { get; set; }
        public string PointRunTime { get; set; }
    }
}
