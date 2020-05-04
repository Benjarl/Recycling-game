using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;
using DataSync;

namespace TestGameFrame
{
    public class ResultData : LabDataBase
    {
        public float CorrectRate { get; set; }
        public float AverageTime { get; set; }
        public List<Garbage> Garbages { get; set; }

        public ResultData(float correctRate, float Averagetime, List<Garbage> garbages)
        {
            CorrectRate = correctRate;
            AverageTime = Averagetime;
            Garbages = garbages;
        }

    }
}