using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVouchermodel
    {
        public ulong VoucherModelId { get; set; }
        public short VoucherModelCountryCode { get; set; }
        public string VoucherModelName { get; set; }
        public string VoucherModelChkBoxModel { get; set; }
        public string VoucherModelDataModel { get; set; }
        public sbyte VoucherModelState { get; set; }
        public string VoucherModelVarParamA { get; set; }
        public string VoucherModelVarParamB { get; set; }
        public long? VoucherModelIntParamA { get; set; }
        public long? VoucherModelIntParamB { get; set; }
        public double? VoucherModelFloatParamA { get; set; }
        public double? VoucherModelFloatParamB { get; set; }
    }
}
