using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseCompany
    {
        public long CompanyId { get; set; }
        public long CompanyCountryCode { get; set; }
        public long? CompanyUpCompanyCode { get; set; }
        public short CompanyGroupNo { get; set; }
        public long CompanyCode { get; set; }
        public string CompanyExtCode { get; set; }
        public short CompanyType { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEnName { get; set; }
        public string CompanyShowName { get; set; }
        public string CompanyEnShowName { get; set; }
        public sbyte CompanyIdtype { get; set; }
        public string CompanyRegisterNo { get; set; }
        public string CompanyTaxIdno { get; set; }
        public string CompanyImage { get; set; }
        public long? CompanyCountry { get; set; }
        public long? CompanyCity { get; set; }
        public long? CompanyLocalCityArea { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWebSite { get; set; }
        public string CompanyTel { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyContactName { get; set; }
        public string CompanyContactNameEn { get; set; }
        public string CompanyContactEmail { get; set; }
        public string CompanyContactTel { get; set; }
        public string CompanyContactCell { get; set; }
        public string CompanyBank { get; set; }
        public string CompanyBankBranch { get; set; }
        public string CompanyBankAccountName { get; set; }
        public string CompanyBankAccount { get; set; }
        public DateTime? CompanyInsertDate { get; set; }
        public DateTime? CompanyUpdateDate { get; set; }
        public sbyte CompanyContractStoreState { get; set; }
        public DateTime? CompanyContractStoreDate { get; set; }
        public short? CompanySettleType { get; set; }
        public short? CompanySettlementDay { get; set; }
        public double CompanyCreditLimit { get; set; }
        public double CompanyYearfee { get; set; }
        public double CompanyAllocatefeeA { get; set; }
        public double CompanyAllocatefeeB { get; set; }
        public double CompanyEachLimit { get; set; }
        public double CompanyDayLimit { get; set; }
        public double CompanyCurrentDayLimit { get; set; }
        public double CompanyMonthLimit { get; set; }
        public double CompanyCurrentMonthLimit { get; set; }
        public long? CompanyPassDealerCode { get; set; }
        public DateTime? CompanyPassDate { get; set; }
        public sbyte? CompanyPassState { get; set; }
        public sbyte CompanyState { get; set; }
        public sbyte? CompanySyncState { get; set; }
        public string CompanyVarParamA { get; set; }
        public string CompanyVarParamB { get; set; }
        public long? CompanyIntParamA { get; set; }
        public long? CompanyIntParamB { get; set; }
        public double? CompanyFloatParamA { get; set; }
        public double? CompanyFloatParamB { get; set; }
    }
}
