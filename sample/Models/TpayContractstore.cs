using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayContractstore
    {
        public long ContractStoreId { get; set; }
        public long ContractStoreCountryCode { get; set; }
        public long ContractStoreCode { get; set; }
        public short ContractStoreType { get; set; }
        public string ContractStoreName { get; set; }
        public long ContractStoreCompanyCode { get; set; }
        public long ContractStorePaymentFlowCode { get; set; }
        public sbyte? ContractStoreCountry { get; set; }
        public string ContractStoreIdno { get; set; }
        public string ContractStoreIdcardDate { get; set; }
        public string ContractStoreIdcardPlace { get; set; }
        public sbyte? ContractStoreIdpic { get; set; }
        public sbyte? ContractStoreIdfrom { get; set; }
        public string ContractStoreAccount { get; set; }
        public string ContractStoreMerchantCode { get; set; }
        public long? ContractStoreNationalE { get; set; }
        public long? ContractStoreCityE { get; set; }
        public sbyte? ContractStoreMerchantType { get; set; }
        public long? ContractStoreBusinessType { get; set; }
        public string ContractStoreMerchantDesc { get; set; }
        public int? ContractStoreCreditLimit { get; set; }
        public short? ContractStoreAgreedDay { get; set; }
        public short? ContractStoreWithdraw { get; set; }
        public short? ContractStoreWithdrawMer { get; set; }
        public string ContractStoreWithdrawSetting { get; set; }
        public string ContractStoreMerchantId { get; set; }
        public string ContractStoreTerminalId { get; set; }
        public string ContractStoreTranPwd { get; set; }
        public string ContractStoreHashKey { get; set; }
        public string ContractStoreHashIv { get; set; }
        public string ContractStoreFrontUrl { get; set; }
        public string ContractStoreBackUrl { get; set; }
        public string ContractStoreResultUrl { get; set; }
        public sbyte ContractStoreState { get; set; }
        public sbyte? ContractStoreSyncState { get; set; }
        public string ContractStoreVarParamA { get; set; }
        public string ContractStoreVarParamB { get; set; }
        public long? ContractStoreIntParamA { get; set; }
        public long? ContractStoreIntParamB { get; set; }
        public double? ContractStoreFloatParamA { get; set; }
        public double? ContractStoreFloatParamB { get; set; }
        public sbyte ContractStoreIsOpen { get; set; }
        public int? ContractStoreInvoiceSupplier { get; set; }
        public string ContractStoreInvoiceMerchantId { get; set; }
        public string ContractStoreInvoiceHashKey { get; set; }
        public string ContractStoreInvoiceHashIv { get; set; }
    }
}
