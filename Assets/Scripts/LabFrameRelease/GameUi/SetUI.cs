using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SetUI : MonoBehaviour
{
    public Button BackBotton;

    public Button NewLevelButton;

    public Button ChangeLevelButton;

    public Button DeleteLevelButton;

    //判斷新增或更改
    public static string set;

    //Panel
    public GameObject MainPanel;

    public GameObject SetLevelPanel;

    public GameObject CreatePanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setstart()
    {
        BackBotton.onClick.AddListener(delegate
        {
            SetLevelPanel.SetActive(false);
            MainPanel.SetActive(true);
        });

        NewLevelButton.onClick.AddListener(delegate
        {
            SetLevelPanel.SetActive(false);
            CreatePanel.SetActive(true);
            set = "New";
        });

        ChangeLevelButton.onClick.AddListener(delegate
        {
            SetLevelPanel.SetActive(false);
            CreatePanel.SetActive(true);
            set = "Change";
        });

        DeleteLevelButton.onClick.AddListener(delegate
        {
            MainPanel.SetActive(true);
            SetLevelPanel.SetActive(false);
        });
    }
}
