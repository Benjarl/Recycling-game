using System;
using System.Collections;
using System.Collections.Generic;
using DataSync;
using UnityEngine;
using LabData;


namespace LabData
{
    public class LabSyncDataDemo : MonoBehaviour,IData
    { 
        public string Id = "Test01";

        public List<Func<LabDataBase>> SaveDataList => new List<Func<LabDataBase>>()
        {
           ()=>new LabBodyData(i,0,0),
           ()=>new LabBodyData(i,i,0)
        };



        // Use this for initialization
        void Start()
        {
           LabDataManager.Instance.LabDataCollectInit(Id);
            StartCoroutine(DataCollectTest());
        }

        private int i=1;

        IEnumerator DataCollectTest()
        {
            LabDataManager.Instance.DataCollect(this, true, 2);
            yield return new WaitForSeconds(2f);
            LabDataManager.Instance.LabDataDispose();
        }
        // Update is called once per frame
        void Update()
        {
            i++;
            Debug.Log(i+"//"+DateTime.Now.Millisecond);
        }

        void OnDisable()
        {
            LabDataManager.Instance?.LabDataDispose();
        }
       
    }
}

