using GameData;
using LabData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameSceneResources))]
public class GameSceneManager : MonoSingleton<GameSceneManager>,IGameManager
{
    private AsyncOperation _operation;

    public Scene CurrentScene { get; private set; }

    public GameSceneResources GameSceneResources { get; private set; }

    public void ChangeScene(List<Action> actions,string sceneName=null)
    {
        //场景名
        
        _operation = null;
        _operation = SceneManager.LoadSceneAsync(sceneName);
        _operation.completed += (AsyncOperation obj) =>
        {
            OnSceneChangeCompleted();
            actions.ForEach(p => p.Invoke());
        };
        _operation.allowSceneActivation = true;
    }


    /// <summary>
    /// 加载后做的事儿
    /// </summary>
    private void OnSceneChangeCompleted()
    {
        CurrentScene = SceneManager.GetActiveScene();
        GameSceneResources = GetComponent<GameSceneResources>();
    }

    
    /// <summary>
    /// 加载UI场景
    /// </summary>
    /// <param name="sceneName"></param>
    //private void ChangeSceneToMainUi(string sceneName)
    //{
    //    _operation = null;
    //    _operation = SceneManager.LoadSceneAsync(sceneName);
    //    //场景加载完后做什么
    //    _operation.completed += (AsyncOperation obj) =>
    //    {
    //       // TODO 加载完场景后做什么，UI做的事儿
    //    };
    //    _operation.allowSceneActivation = true;
    //}
    
    public void ManagerInit()
    {
        //切换到主UI场景
        ChangeScene(new List<Action>()
        {
            GameUIManager.Instance.StartMainUiLogic
        },GobalData.MainUiScene);
    }

    public void ManagerDispose()
    {
        
    }
}
