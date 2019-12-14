using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameTaskConfig
{
    public float Speed { get; set; }

    public GameTaskConfig()
    {
        Speed = 100;
    }
}
