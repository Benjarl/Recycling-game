using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataSync;


namespace GameData
{
    public class GameFlowData : LabDataBase
    {
        /// <summary>
        /// 语言
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; } = "Test01";

        public string LevelName { get; set; }
        public int Mode { get; set; }
        public int Time { get; set; }
        public string Trashnumber { get; set; }

        /// <summary>
        /// FlowData 构造函数
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="languageType"></param>
        /// <param name="remindType"></param>
        /// <param name="gameData"></param>
        public GameFlowData(string level, int mode, int time, string trashnumber)
        {
            LevelName = level;
            Mode = mode;
            Time = time;
            Trashnumber = trashnumber;
        }

        public GameFlowData()
        {
        }
    }
}