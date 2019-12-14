using System;
using System.Collections;
using System.Collections.Generic;
using DataSync;
using LabData;
using UnityEngine;

public class LabResultDataDemo : MonoBehaviour, IData
{
    public List<Func<LabDataBase>> SaveDataList => new List<Func<LabDataBase>>()
    {
       ()=>new LabResultDemoData("testResultTest01", "testResultTest02"),
       ()=>new LabResultDemoData1("testResultTest04", "testResultTest03")
    };


    void Start()
    {
        LabDataManager.Instance.DataCollect(this, false);
    }



}
