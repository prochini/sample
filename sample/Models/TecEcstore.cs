using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstore
    {
        public long EcstoreId { get; set; }
        public long EcstoreCountryCode { get; set; }
        public long EcstoreCompanyCode { get; set; }
        public long EcstoreCode { get; set; }
        public string EcstoreAccount { get; set; }
        public string EcstoreExtCode { get; set; }
        public string EcstoreName { get; set; }
        public string EcstoreShowName { get; set; }
        public short EcstoreType { get; set; }
        public double? EcstoreLng { get; set; }
        public double? EcstoreLat { get; set; }
        public long EcstoreCountry { get; set; }
        public long? EcstoreCity { get; set; }
        public long? EcstoreLocalCityArea { get; set; }
        public string EcstoreAddress { get; set; }
        public string EcstoreTel { get; set; }
        public string EcstoreOpenTime { get; set; }
        public string EcstoreFeatures { get; set; }
        public string EcstoreLogo { get; set; }
        public string EcstoreImage1 { get; set; }
        public string EcstoreImage2 { get; set; }
        public string EcstoreImage3 { get; set; }
        public string EcstoreImage4 { get; set; }
        public string EcstoreImage5 { get; set; }
        public string EcstoreWebUrl { get; set; }
        public string EcstoreFburl { get; set; }
        public string EcstoreLineUrl { get; set; }
        public string EcstoreIgurl { get; set; }
        public DateTime EcstoreInsertDate { get; set; }
        public DateTime EcstoreUpdateDate { get; set; }
        public string EcstoreDemo { get; set; }
        public sbyte? EcstoreIsPraise { get; set; }
        public sbyte? EcstoreIsRecomm { get; set; }
        public sbyte? EcstoreIsPayment { get; set; }
        public long? EcstorePassDealerCode { get; set; }
        public DateTime? EcstorePassDate { get; set; }
        public sbyte? EcstorePassState { get; set; }
        public sbyte EcstoreState { get; set; }
        public sbyte? EcstoreSyncState { get; set; }
        public string EcstoreVarParamA { get; set; }
        public string EcstoreVarParamB { get; set; }
        public long? EcstoreIntParamA { get; set; }
        public long? EcstoreIntParamB { get; set; }
        public double? EcstoreFloatParamA { get; set; }
        public double? EcstoreFloatParamB { get; set; }
        public string EcstoreNearby { get; set; }
        public sbyte? EcstoreIsSelfpick { get; set; }
        public long? EcstorePickCity { get; set; }
        public long? EcstorePickCityArea { get; set; }
        public string EcstorePickAddress { get; set; }
        public double? EcstorePointFee { get; set; }
        public string EcstoreJustKa { get; set; }
        public sbyte EcstoreIsOnline { get; set; }
        public sbyte EcstoreTemplateState { get; set; }
        public string EcstoreDeliveryUrl { get; set; }
        public sbyte? EcstoreAppUrltarget { get; set; }
        public string EcstoreTakeoutUrl { get; set; }
        public sbyte? EcstoreTakeoutAppUrltarget { get; set; }
    }
}
