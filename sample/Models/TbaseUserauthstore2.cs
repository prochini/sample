using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserauthstore2
    {
        public long UserAuthStoreId { get; set; }
        public long UserAuthStoreUserInfoCode { get; set; }
        public long UserAuthStoreAuthStoreCode { get; set; }
        public string UserAuthStoreToken { get; set; }
        public DateTime UserAuthStoreLimitDate { get; set; }
        public DateTime UserAuthStoreDate { get; set; }
        public sbyte UserAuthStoreState { get; set; }
        public string UserAuthStoreVarParamA { get; set; }
        public string UserAuthStoreVarParamB { get; set; }
        public long? UserAuthStoreIntParamA { get; set; }
        public long? UserAuthStoreIntParamB { get; set; }
        public double? UserAuthStoreFloatParamA { get; set; }
        public double? UserAuthStoreFloatParamB { get; set; }
        public long UserAuthStoreCode { get; set; }
    }
}
