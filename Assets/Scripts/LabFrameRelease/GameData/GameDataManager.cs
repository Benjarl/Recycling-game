using System.Collections;
using System.Collections.Generic;
using System.IO;
using LabData;
using Newtonsoft.Json;
using UnityEngine;

[RequireComponent(typeof(LabDataManager))]
public class GameDataManager : MonoSingleton<GameDataManager>, IGameManager
{
    public TaskData NowTaskData;
    public T GetConfig<T>() where T : new()
    {
        var path = Application.streamingAssetsPath + "/" + typeof(T).Name + ".json";
        if (!File.Exists(path))
        {
            var json = JsonConvert.SerializeObject(new T());
            var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(json);
            sw.Close();
        }

        StreamReader sr = new StreamReader(path);
        return JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
    }


    public void LabDataInit()
    {
        LabDataManager.Instance.LabDataCollectInit(GameApplication.FlowData.UserId);
    }

    public void ManagerInit()
    {
    }

    public void ManagerDispose()
    {
        LabDataManager.Instance.LabDataDispose();
    }

    
}
