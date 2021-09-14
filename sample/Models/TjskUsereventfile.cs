using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TjskUsereventfile
    {
        public string UserEventFileId { get; set; }
        public long UserEventFileUserInfoCode { get; set; }
        public long UserEventFileFileSettingsId { get; set; }
        public long UserEventFileType { get; set; }
        public string UserEventFileVerifyStatus { get; set; }
        public string UserEventFileNote { get; set; }
        public string UserEventFileVerifyUid { get; set; }
        public string UserEventFileVerifyName { get; set; }
        public DateTime? UserEventFileVerifyDate { get; set; }
        public string UserEventFileCrtUid { get; set; }
        public string UserEventFileCrtName { get; set; }
        public DateTime UserEventFileCrtDate { get; set; }
        public string UserEventFileMdyUid { get; set; }
        public string UserEventFileMdyName { get; set; }
        public DateTime UserEventFileMdyDate { get; set; }
    }
}
