using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebFilesetting
    {
        public long FileSettingsId { get; set; }
        public long? FileSettingsMapCode { get; set; }
        public short FileSettingsMode { get; set; }
        public string FileSettingsName { get; set; }
        public string FileSettingsFile { get; set; }
        public long? FileSettingsSort { get; set; }
        public sbyte FileSettingsState { get; set; }
        public sbyte? FileSettingsSyncState { get; set; }
        public DateTime FileSettingsDate { get; set; }
        public string FileSettingsVarParamA { get; set; }
        public string FileSettingsVarParamB { get; set; }
        public long? FileSettingsIntParamA { get; set; }
        public long? FileSettingsIntParamB { get; set; }
        public double? FileSettingsFloatParamA { get; set; }
        public double? FileSettingsFloatParamB { get; set; }
    }
}
