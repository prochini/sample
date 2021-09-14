using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class ViewUsermission
    {
        public long UserMissionId { get; set; }
        public long UserMissionMissionCode { get; set; }
        public long UserMissionUserInfoCode { get; set; }
        public short UserMissionFreqCount { get; set; }
        public short UserMissionCompleteCount { get; set; }
        public sbyte UserMissionIsReleased { get; set; }
        public DateTime UserMissionRelLimtDate { get; set; }
        public double UserMissionAmountPoint { get; set; }
        public DateTime? UserMissionReleasedDate { get; set; }
        public DateTime? UserMissionUpdateDate { get; set; }
        public DateTime UserMissionDate { get; set; }
        public sbyte UserMissionState { get; set; }
    }
}
