using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;
using DataSync;

namespace TestGameFrame
{
    public class TaskConfig : LabDataBase
    {
        public string LevelName { get; set; }
        public int Mode { get; set; }
        public int Time { get; set; }
        public string Trashnumber { get; set; }

        public TaskConfig(string level, int mode, int time, string trashnumber)
        {
            LevelName = level;
            Mode = mode;
            Time = time;
            Trashnumber = trashnumber;
        }

    }
}
