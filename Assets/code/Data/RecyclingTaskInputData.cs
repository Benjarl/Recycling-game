
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;
using DataSync;

namespace GameData
{
    public class RecyclingTaskInputData : LabDataBase
    {
        public string TaskName { get; set; }
        public Mode Mode { get; set; }
        public float Time { get; set; }
        public List<int> Trashnumber { get; set; }

        public RecyclingTaskInputData(string taskName, Mode mode, float time, List<int> trashnumber)
        {
            TaskName = taskName;
            Mode = mode;
            Time = time;
            Trashnumber = trashnumber;
        }

        public RecyclingTaskInputData()
        {
           
        }

    }
}
