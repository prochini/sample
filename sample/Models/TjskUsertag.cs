using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TjskUsertag
    {
        public ulong UserTagUserInfoCode { get; set; }
        public string UserTagName { get; set; }
        public string UserTagCrtUid { get; set; }
        public string UserTagCrtName { get; set; }
        public DateTime UserTagCrtDate { get; set; }
        public string UserTagMdyUid { get; set; }
        public string UserTagMdyName { get; set; }
        public DateTime UserTagMdyDate { get; set; }
    }
}
