﻿using System;
using System.Collections;
using System.Collections.Generic;
using DataSync;
using UnityEngine;

namespace LabData
{
    public interface IData
    {
       List<Func<LabDataBase>> SaveDataList { get; } 
    }
}


