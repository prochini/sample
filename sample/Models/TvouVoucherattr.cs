using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucherattr
    {
        public long VoucherAttrId { get; set; }
        public long VoucherAttrVoucherCode { get; set; }
        public sbyte VoucherAttrAttributeType { get; set; }
        public long VoucherAttrAttributeCode { get; set; }
        public string VoucherAttrAttributeName { get; set; }
        public long VoucherAttrAttributeValueCode { get; set; }
        public string VoucherAttrAttributeValueName { get; set; }
        public sbyte? VoucherAttrSyncState { get; set; }
        public string VoucherAttrVarParamA { get; set; }
        public string VoucherAttrVarParamB { get; set; }
        public long? VoucherAttrIntParamA { get; set; }
        public long? VoucherAttrIntParamB { get; set; }
        public double? VoucherAttrFloatParamA { get; set; }
        public double? VoucherAttrFloatParamB { get; set; }
        public sbyte? VoucherAttrIsShowtvouVoucherattrcol { get; set; }
        public sbyte? VoucherAttrIsShow { get; set; }
    }
}
