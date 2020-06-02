using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataSync;
using Mindfrog.Recycling;

namespace GameData
{
    public class GameFlowData : LabDataBase
    {

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        public RecyclingScopeInput TaskData { get; set; }


        /// <summary>
        /// FlowData 构造函数
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="languageType"></param>
        /// <param name="remindType"></param>
        /// <param name="gameData"></param>
        public GameFlowData(string UserID , RecyclingScopeInput taskData)
        {
            UserId = UserID;
            TaskData = taskData;
        }

        public GameFlowData()
        {
        }
    }
}