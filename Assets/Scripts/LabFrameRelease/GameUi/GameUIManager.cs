using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;

public class GameUIManager : MonoSingleton<GameUIManager>, IGameManager
{
    public void StartMainUiLogic()
    {
        MainUI mainUI = FindObjectOfType<MainUI>();
        mainUI.StartUI();
    }

    public void StartGameUiLogic()
    {
        recyclelist Recyclelist = FindObjectOfType<recyclelist>();
        Recyclelist.timede();
    }

    public void ManagerInit()
    {
    }

    public void ManagerDispose()
    {

    }
}