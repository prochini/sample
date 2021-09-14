using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntGame
    {
        public long GameId { get; set; }
        public long GameCode { get; set; }
        public short GameCountryCode { get; set; }
        public short GameType { get; set; }
        public short GameTypeSpace { get; set; }
        public string GameName { get; set; }
        public string GameExtName { get; set; }
        public string GameRuleText { get; set; }
        public string GameImage { get; set; }
        public int GameDedPoint { get; set; }
        public int GamePlayCount { get; set; }
        public DateTime GameOnDate { get; set; }
        public DateTime GameOffDate { get; set; }
        public DateTime GameOnlineDate { get; set; }
        public DateTime GameOfflineDate { get; set; }
        public sbyte GameTemplateState { get; set; }
        public sbyte GameState { get; set; }
        public sbyte? GameSyncState { get; set; }
        public string GameVarParamA { get; set; }
        public string GameVarParamB { get; set; }
        public long? GameIntParamA { get; set; }
        public long? GameIntParamB { get; set; }
        public double? GameFloatParamA { get; set; }
        public double? GameFloatParamB { get; set; }
        public string GameScratchImage { get; set; }
        public string GameAdimage { get; set; }
        public short GameIsOnline { get; set; }
        public string GameScratchItemImage { get; set; }
        public sbyte GameIsDayLimit { get; set; }
        public short GameConditionType { get; set; }
        public string GamePlayCondition { get; set; }
        public string GameTag { get; set; }
        public string GameMsgBody { get; set; }
        public string GameMsgRbtext { get; set; }
        public string GameMsgRburl { get; set; }
        public string GameMsgLbtext { get; set; }
        public string GameMsgLburl { get; set; }
    }
}
