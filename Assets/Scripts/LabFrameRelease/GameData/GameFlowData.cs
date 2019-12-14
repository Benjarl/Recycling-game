using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 游戏语言类别
/// </summary>
public enum Language
{
    English,
    简体,
    繁体
}
/// <summary>
/// 提醒方式
/// </summary>
public enum RemindType
{
    Text,
    Voice,
    TextVoice
}

/// <summary>
/// 游戏运行的平台
/// </summary>
public enum GamePlantType
{
    Pc,
    Vr
}

namespace GameData
{
    public class GameFlowData
    {
        public RemindType RemindType { get; set; }

        public Language Language { get; set; }

        public string UserId { get; set; }

        public GameFlowData(RemindType remindType, Language language, string id)
        {
            RemindType = remindType;
            Language = language;
            UserId = id;
        }
    }

}

