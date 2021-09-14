using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpSubstore
    {
        public long SubStoreId { get; set; }
        public long SubStoreTableNo { get; set; }
        public long SubStoreCompanyCode { get; set; }
        public long SubStoreEcstoreCode { get; set; }
        public DateTime SubStoreInsertDate { get; set; }
        public sbyte SubStoreState { get; set; }
        public string SubStoreVarParamA { get; set; }
        public string SubStoreVarParamB { get; set; }
        public string SubStoreVarParamC { get; set; }
        public long? SubStoreIntParamA { get; set; }
        public long? SubStoreIntParamB { get; set; }
        public long? SubStoreIntParamC { get; set; }
        public double? SubStoreFloatParamA { get; set; }
        public double? SubStoreFloatParamB { get; set; }
        public double? SubStoreFloatParamC { get; set; }
    }
}
