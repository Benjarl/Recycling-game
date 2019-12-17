using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;
using System.Linq;
using System;
using GameData;

public class GameApplication : MonoSingleton<GameApplication>
{
    private List<IGameManager> _mangerList;

    public static GameFlowData FlowData { get; private set; }
    public string UserID;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    { 
        //开始做什么
        GameApplicationInit();
    }

    public void GameApplicationInit()
    {
        _mangerList = FindObjectsOfType<MonoBehaviour>().OfType<IGameManager>().ToList();
        _mangerList.ForEach(p => p.ManagerInit());
    }



    public void StartGameFlow(GameFlowData flowData)
    {
        FlowData = flowData;
        GameSceneManager.Instance.ChangeScene(new List<Action>()
        {
            GameUIManager.Instance.StartGameUiLogic


        }, GobalData.GameScene);
    }

    public void ManagersDispose()
    {
        FlowData = null;
        _mangerList.ForEach(p => p.ManagerDispose());
    }
}
