using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPgmember
    {
        public long PgmemberId { get; set; }
        public long PgmemberNo { get; set; }
        public long PgmemberToken { get; set; }
        public string PgmemberExtMemberId { get; set; }
        public string PgmemberMemberEmail { get; set; }
        public string PgmemberMemberName { get; set; }
        public string PgmemberMemberPhone { get; set; }
        public string PgmemberPaymentToken { get; set; }
        public sbyte PgmemberState { get; set; }
        public DateTime PgmemberDate { get; set; }
        public string PgmemberVarParamA { get; set; }
        public string PgmemberVarParamB { get; set; }
        public long? PgmemberIntParamA { get; set; }
        public long? PgmemberIntParamB { get; set; }
        public double? PgmemberFloatParamA { get; set; }
        public double? PgmemberFloatParamB { get; set; }
    }
}
