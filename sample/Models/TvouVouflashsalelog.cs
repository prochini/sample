using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVouflashsalelog
    {
        public long VouFlashSaleLogId { get; set; }
        public long VouFlashSaleLogVouFlashSaleCode { get; set; }
        public long VouFlashSaleLogTvouVouFlashSalePartId { get; set; }
        public long VouFlashSaleLogVoucherCode { get; set; }
        public long VouFlashSaleLogUserInfoCode { get; set; }
        public DateTime VouFlashSaleLogDate { get; set; }
        public string VouFlashSaleLogVarParamA { get; set; }
        public string VouFlashSaleLogVarParamB { get; set; }
        public long? VouFlashSaleLogIntParamA { get; set; }
        public long? VouFlashSaleLogIntParamB { get; set; }
        public double? VouFlashSaleLogFloatParamA { get; set; }
        public double? VouFlashSaleLogFloatParamB { get; set; }
    }
}
