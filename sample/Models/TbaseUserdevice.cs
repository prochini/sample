using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserdevice
    {
        public long UserDeviceId { get; set; }
        public long UserDeviceCode { get; set; }
        public string UserDeviceDeviceCode { get; set; }
        public string UserDeviceApptoken { get; set; }
        public string UserDeviceIp { get; set; }
        public DateTime? UserDeviceDate { get; set; }
        public sbyte UserDeviceState { get; set; }
        public sbyte? UserDeviceSyncState { get; set; }
        public string UserDeviceVarParamA { get; set; }
        public string UserDeviceVarParamB { get; set; }
        public long? UserDeviceIntParamA { get; set; }
        public long? UserDeviceIntParamB { get; set; }
        public double? UserDeviceFloatParamA { get; set; }
        public double? UserDeviceFloatParamB { get; set; }
    }
}
