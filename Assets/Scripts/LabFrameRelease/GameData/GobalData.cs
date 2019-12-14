using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataSync;
using JetBrains.Annotations;
using UnityEngine;

namespace GameData
{
    public class GobalData
    {
        /// <summary>
        /// 全局音量
        /// </summary>
        public  float GobalAudioVolume { get; set; }
        /// <summary>
        /// 全局特效音量
        /// </summary>
        public  float GobalEffectVolume { get; set; }
        /// <summary>
        /// 全局BGM音量
        /// </summary>
        public float GobalBgmVolume { get; set; }

        /// <summary>
        /// 游戏的主UI场景名
        /// </summary>
        public const string MainUiScene = "Menu";
        public const string GameScene = "SampleScene";


    }

}

