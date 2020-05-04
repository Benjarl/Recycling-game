using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;
using DataSync;

namespace TestGameFrame
{
    public class Garbage : LabDataBase
    {
        public int GarbageID { get; set; }
        public bool IsSuccess { get; set; }
        public float Timer { get; set; }

        public Garbage(int GarbageId, bool isSuccess, float timer)
        {
            GarbageID = GarbageId;
            IsSuccess = isSuccess;
            Timer = timer;
        }

    }
}
