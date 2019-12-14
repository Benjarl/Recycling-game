using System;
using System.Collections;
using System.Collections.Generic;
using GameData;
using UnityEngine;
using UnityEngine.UI;
using LabData;
using System.IO;

public class MainUI : MonoBehaviour
{
    public RemindType UI_RemindType;

    public Language UI_Language;

    public string UI_UserID;

    public void StartButton()
    {
        GameApplication.Instance.StartGameFlow(new GameFlowData(UI_RemindType, UI_Language, UI_UserID));
    }

    public static string startpath;

    //Main Panel
    public InputField InputUserName;

    public Dropdown Level;

    public Button NextBotton;

    public Button Leave;

    public Button SetLevelButton;

    //Set Panel
    public Dropdown LevelDropdown;

    public Button BackBotton;

    public Button NewLevelButton;

    public Button ChangeLevelButton;

    public Button DeleteLevelButton;

    //Create Panel
    public Text CreateTitle;

    public InputField LevelNameInput;

    public Dropdown ModeDropdown;

    public InputField TimeInputField;

    public Text Timetext;

    public GameObject TimeInputFieldO;

    public GameObject TimetextO;

    public Button ChooseTrashButton;

    public Button BackButton;

    public Button SaveButton;

    //TrashPanel
    public InputField TrashNumber;

    public Button TrashSaveButton;

    public Button TrashBackButton;

    public string Tempnumber;

    //判斷新增或更改
    public static string set;

    //Panel
    public GameObject MainPanel;

    public GameObject SetLevelPanel;

    public GameObject CreatePanel;

    public GameObject TrashPanel;

    //MainUI
    public void StartUI()
    {
        //clean dropdown
        Level.ClearOptions();

        //必须先创建对应数据的文件夹
        LabTools.CreateDataFolder<TaskData>();

        if (LabTools.GetDataName<TaskData>() != null)
        {
            //選關卡名稱
            List<string> one = new List<string>();
            one = LabTools.GetDataName<TaskData>();
            for (int i = 0; i < one.Count; i++)
            {
                var two = LabTools.GetData<TaskData>(one[i]);
                Level.options.Add(new Dropdown.OptionData() { text = two.LevelName });
            }
        }

        // panel In
        MainPanel.SetActive(true);
        SetLevelPanel.SetActive(false);
        CreatePanel.SetActive(false);
        TrashPanel.SetActive(false);

        NextBotton.onClick.AddListener(delegate
        {
            GameApplication.Instance.UserID = InputUserName.text;
            //搜尋對應現有的任務
            List<string> temp = new List<string>();
            temp = LabTools.GetDataName<TaskData>();
            for (int i = 0; i < temp.Count; i++)
            {
                var tempData = LabTools.GetData<TaskData>(temp[i]);
                if (tempData.LevelName == Level.captionText.text)
                {
                    GameDataManager.Instance.NowTaskData = tempData;
                    break;
                }
            }

            GameSceneManager.Instance.ChangeScene(new List<Action>()
            {
                GameUIManager.Instance.StartGameUiLogic
            }, GobalData.GameScene);
        });

        Leave.onClick.AddListener(delegate
        {
            Application.Quit();
        });

        SetLevelButton.onClick.AddListener(delegate
        {
            MainPanel.SetActive(false);
            SetLevelPanel.SetActive(true);
            Setstart();
        });
    }

    //SetUI
    public void Setstart()
    {
        LevelDropdown.ClearOptions();

        if (LabTools.GetDataName<TaskData>() != null)
        {
            //選關卡名稱
            List<string> one = new List<string>();
            one = LabTools.GetDataName<TaskData>();
            for (int i = 0; i < one.Count; i++)
            {
                var two = LabTools.GetData<TaskData>(one[i]);
                LevelDropdown.options.Add(new Dropdown.OptionData() { text = two.LevelName });
            }
        }

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
            StartchangePanel();
        });

        ChangeLevelButton.onClick.AddListener(delegate
        {
            SetLevelPanel.SetActive(false);
            CreatePanel.SetActive(true);
            set = "Change";
            StartchangePanel();
        });
        //刪除
        DeleteLevelButton.onClick.AddListener(delegate
        {
            string path = Application.dataPath + "/GameData/" + "/TaskData/" + LevelDropdown.captionText.text + ".json";
            if (File.Exists(path))
                File.Delete(path);
            path = Application.dataPath + "/GameData/" + "/TaskData/" + LevelDropdown.captionText.text + ".json.meta";
            if (File.Exists(path))
                File.Delete(path);

            Level.ClearOptions();
            LevelDropdown.ClearOptions();

            if (LabTools.GetDataName<TaskData>() != null)
            {
                //選關卡名稱
                List<string> one = new List<string>();
                one = LabTools.GetDataName<TaskData>();
                for (int i = 0; i < one.Count; i++)
                {
                    var two = LabTools.GetData<TaskData>(one[i]);
                    LevelDropdown.options.Add(new Dropdown.OptionData() { text = two.LevelName });
                }
            }

            if (LabTools.GetDataName<TaskData>() != null)
            {
                //選關卡名稱
                List<string> one = new List<string>();
                one = LabTools.GetDataName<TaskData>();
                for (int i = 0; i < one.Count; i++)
                {
                    var two = LabTools.GetData<TaskData>(one[i]);
                    Level.options.Add(new Dropdown.OptionData() { text = two.LevelName });
                }
            }

            MainPanel.SetActive(true);
            SetLevelPanel.SetActive(false);
        });
    }

    //CreateUI
    public void StartchangePanel()
    {
        ChooseTrashButton.onClick.AddListener(delegate
        {
            CreatePanel.SetActive(false);
            TrashPanel.SetActive(true);
            Starttrash();
        });

        BackButton.onClick.AddListener(delegate
        {
            CreatePanel.SetActive(false);
            SetLevelPanel.SetActive(true);
        });

        SaveButton.onClick.AddListener(delegate
        {
            if (ModeDropdown.value == 0)
                TimeInputField.text = "0";

            var Data = new TaskData(LevelNameInput.text, ModeDropdown.value, Convert.ToInt32(TimeInputField.text), (TrashNumber.text + " "));

            if (set == "New")
                LabTools.WriteData(Data, LevelNameInput.text);

            else if (set == "Change")
                LabTools.WriteData(Data, LevelNameInput.text, true);

            Level.ClearOptions();
            LevelDropdown.ClearOptions();

            if (LabTools.GetDataName<TaskData>() != null)
            {
                //選關卡名稱
                List<string> one = new List<string>();
                one = LabTools.GetDataName<TaskData>();
                for (int i = 0; i < one.Count; i++)
                {
                    var two = LabTools.GetData<TaskData>(one[i]);
                    LevelDropdown.options.Add(new Dropdown.OptionData() { text = two.LevelName });
                }
            }

            if (LabTools.GetDataName<TaskData>() != null)
            {
                //選關卡名稱
                List<string> one = new List<string>();
                one = LabTools.GetDataName<TaskData>();
                for (int i = 0; i < one.Count; i++)
                {
                    var two = LabTools.GetData<TaskData>(one[i]);
                    Level.options.Add(new Dropdown.OptionData() { text = two.LevelName });
                }
            }

            CreatePanel.SetActive(false);
            SetLevelPanel.SetActive(true);
        });

        ModeDropdown.onValueChanged.AddListener(delegate
        {
            if (ModeDropdown.value == 0)
            {
                TimeInputFieldO.SetActive(false);
                TimetextO.SetActive(false);
            }
            else
            {
                TimeInputFieldO.SetActive(true);
                TimetextO.SetActive(true);
            }
        });

        if (set == "New")
            Startnew();

        else if (set == "Change")
            Startchange();
    }

    public void Startnew()
    {
        CreateTitle.text = "新增關卡";
        LevelNameInput.text = "";
        ModeDropdown.value = 0;
        TimeInputField.text = "";
        TrashNumber.text = "";
        TimeInputFieldO.SetActive(false);
        TimetextO.SetActive(false);
    }

    public void Startchange()
    {
        CreateTitle.text = "編輯關卡";
        //讀取現有關卡
        List<string> temp = new List<string>();
        temp = LabTools.GetDataName<TaskData>();
        for (int i = 0; i < temp.Count; i++)
        {
            var Data = LabTools.GetData<TaskData>(temp[i]);
            if (Data.LevelName == LevelDropdown.captionText.text)
            {
                LevelNameInput.text = Data.LevelName;
                ModeDropdown.value = Data.Mode;
                TimeInputField.text = Data.Time.ToString();
                TrashNumber.text = Data.Trashnumber;
                break;
            }
        }
        if (ModeDropdown.value == 0)
        {
            TimeInputFieldO.SetActive(false);
            TimetextO.SetActive(false);
        }
        else
        {
            TimeInputFieldO.SetActive(true);
            TimetextO.SetActive(true);
        }
    }

    //TrashUI
    public void Starttrash()
    {
        Tempnumber = TrashNumber.text;

        TrashBackButton.onClick.AddListener(delegate
        {
            TrashNumber.text = Tempnumber;
            TrashPanel.SetActive(false);
            CreatePanel.SetActive(true);
        });

        TrashSaveButton.onClick.AddListener(delegate
        {
            Tempnumber = TrashNumber.text;
            TrashPanel.SetActive(false);
            CreatePanel.SetActive(true);
        });
    }
}
