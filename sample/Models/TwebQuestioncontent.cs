using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebQuestioncontent
    {
        public ulong QuestionContentId { get; set; }
        public short QuestionContentMode { get; set; }
        public long QuestionContentCategoryCode { get; set; }
        public long QuestionContentCode { get; set; }
        public string QuestionContentTitle { get; set; }
        public string QuestionContentBody { get; set; }
        public DateTime QuestionContentReleaseDate { get; set; }
        public DateTime QuestionContentEndDate { get; set; }
        public DateTime QuestionContentInsertDate { get; set; }
        public long QuestionContentSort { get; set; }
        public sbyte QuestionContentState { get; set; }
        public sbyte? QuestionContentSyncState { get; set; }
        public string QuestionContentVarParamA { get; set; }
        public string QuestionContentVarParamB { get; set; }
        public long? QuestionContentIntParamA { get; set; }
        public long? QuestionContentIntParamB { get; set; }
        public double? QuestionContentFloatParamA { get; set; }
        public double? QuestionContentFloatParamB { get; set; }
        public string QuestionContentUpdateDealer { get; set; }
        public string QuestionContentInsertDealer { get; set; }
        public DateTime? QuestionContentUpdatDate { get; set; }
        public DateTime? QuestionContentUpdateDate { get; set; }
        public sbyte QuestionContentIsShow { get; set; }
    }
}
