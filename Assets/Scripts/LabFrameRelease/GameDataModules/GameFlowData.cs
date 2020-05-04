﻿using System.Collections;
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
        public string UserId { get; set; }

        public RecyclingTaskInputData TaskData { get; set; }


        /// <summary>
        /// FlowData 构造函数
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="languageType"></param>
        /// <param name="remindType"></param>
        /// <param name="gameData"></param>
        public GameFlowData(string UserID , Language language, RecyclingTaskInputData taskData)
        {
            UserId = UserID;
            Language = language;
            TaskData = taskData;
        }

        public GameFlowData()
        {
        }
    }
}