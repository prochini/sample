using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class ViewCardlist
    {
        public long UserFavouriteUserInfoCode { get; set; }
        public long? UserFavouriteTypeCode { get; set; }
        public string UserFavouriteText2 { get; set; }
        public DateTime? MaxUserCardChangeLogDate { get; set; }
    }
}
