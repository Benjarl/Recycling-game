using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConfig
{
    public float EnterTimeBase { get; set; }

    public float Easy_Time { get; set; }
    public float Normal_Time { get; set; }
    public float Hard_Time { get; set; }

    public EnemyConfig()
    {
        EnterTimeBase = 4;
        Easy_Time = 0;
        Normal_Time = 1;
        Hard_Time = 2;
    }
}
