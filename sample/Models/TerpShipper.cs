using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpShipper
    {
        public long ShipperId { get; set; }
        public long ShipperTableNo { get; set; }
        public long ShipperEcstoreCode { get; set; }
        public long ShipperEclogisticsId { get; set; }
        public short? ShipperDeliveryWays { get; set; }
        public string ShipperConsumerName { get; set; }
        public string ShipperRecName { get; set; }
        public string ShipperRecTel { get; set; }
        public long ShipperRecCountry { get; set; }
        public long ShipperRecCity { get; set; }
        public long ShipperRecCityArea { get; set; }
        public string ShipperRecAddress { get; set; }
        public DateTime ShipperShippingDate { get; set; }
        public DateTime? ShipperArrivalDate { get; set; }
        public DateTime? ShipperAutoArrivalDate { get; set; }
        public string ShipperShippingNo { get; set; }
        public string ShipperVideoUrl { get; set; }
        public string ShipperImage1 { get; set; }
        public string ShipperImage2 { get; set; }
        public string ShipperImage3 { get; set; }
        public DateTime ShipperInsertDate { get; set; }
        public sbyte ShipperState { get; set; }
        public string ShipperVarParamA { get; set; }
        public string ShipperVarParamB { get; set; }
        public long? ShipperIntParamA { get; set; }
        public long? ShipperIntParamB { get; set; }
        public double? ShipperFloatParamA { get; set; }
        public double? ShipperFloatParamB { get; set; }
        public string ShipperRecEmail { get; set; }
    }
}
