﻿
using System;
using System.Collections;
using System.Collections.Generic;
using GameData;
using UnityEngine;
using UnityEngine.UI;
using LabData;
using System.IO;
using System.Text.RegularExpressions;

namespace TestGameFrame
{
    public class MainUI : MonoBehaviour
    {
        public static string startpath;

        List<int> trashnumber = new List<int>();

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
        public void Start()
        {
            //clean dropdown
            Level.ClearOptions();

            //必须先创建对应数据的文件夹
            LabTools.CreateDataFolder<RecyclingTaskInputData>();

            if (LabTools.GetDataName<RecyclingTaskInputData>() != null)
            {
                //選關卡名稱
                List<string> one = new List<string>();
                one = LabTools.GetDataName<RecyclingTaskInputData>();
                for (int i = 0; i < one.Count; i++)
                {
                    var two = LabTools.GetData<RecyclingTaskInputData>(one[i]);
                    Level.options.Add(new Dropdown.OptionData() { text = two.TaskName });

                }
            }

            // panel In
            MainPanel.SetActive(true);
            SetLevelPanel.SetActive(false);
            CreatePanel.SetActive(false);
            TrashPanel.SetActive(false);

            NextBotton.onClick.AddListener(delegate
            {
                RecyclingTaskInputData taskconfig = new RecyclingTaskInputData();
                GameFlowData flowdata = new GameFlowData();
                //搜尋對應現有的任務
                List<string> temp = new List<string>();
                temp = LabTools.GetDataName<RecyclingTaskInputData>();
                for (int i = 0; i < temp.Count; i++)
                {
                    var tempData = LabTools.GetData<RecyclingTaskInputData>(temp[i]);
                    if (tempData.TaskName == Level.captionText.text)
                    {
                        taskconfig = tempData;
                        break;
                    }
                }
                GameDataManager.LabDataManager.LabDataCollectInit(() => InputUserName.text);
                GameDataManager.FlowData = flowdata;
                GameDataManager.FlowData.UserId = InputUserName.text;
                GameDataManager.TaskData = taskconfig;
                var GFData = new GameFlowData(InputUserName.text, Language.繁体, taskconfig);
                LabTools.WriteData(GFData, InputUserName.text, true);
                GameSceneManager.Instance.Change2MainScene();
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

            if (LabTools.GetDataName<RecyclingTaskInputData>() != null)
            {
                //選關卡名稱
                List<string> one = new List<string>();
                one = LabTools.GetDataName<RecyclingTaskInputData>();
                for (int i = 0; i < one.Count; i++)
                {
                    var two = LabTools.GetData<RecyclingTaskInputData>(one[i]);
                    LevelDropdown.options.Add(new Dropdown.OptionData() { text = two.TaskName });
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
                LabTools.DeleteData<RecyclingTaskInputData>(LevelDropdown.captionText.text);

                Level.ClearOptions();
                LevelDropdown.ClearOptions();

                if (LabTools.GetDataName<RecyclingTaskInputData>() != null)
                {
                //選關卡名稱
                List<string> one = new List<string>();
                    one = LabTools.GetDataName<RecyclingTaskInputData>();
                    for (int i = 0; i < one.Count; i++)
                    {
                        var two = LabTools.GetData<RecyclingTaskInputData>(one[i]);
                        LevelDropdown.options.Add(new Dropdown.OptionData() { text = two.TaskName });
                    }
                }

                if (LabTools.GetDataName<RecyclingTaskInputData>() != null)
                {
                //選關卡名稱
                List<string> one = new List<string>();
                    one = LabTools.GetDataName<RecyclingTaskInputData>();
                    for (int i = 0; i < one.Count; i++)
                    {
                        var two = LabTools.GetData<RecyclingTaskInputData>(one[i]);
                        Level.options.Add(new Dropdown.OptionData() { text = two.TaskName });
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

                trashnumber.Clear();
                string[] sArray = TrashNumber.text.Split( );
                for(int i=0;i<sArray.Length;i++)
                    trashnumber.Add(Convert.ToInt32(sArray[i]));

                var Data = new RecyclingTaskInputData(LevelNameInput.text, (Mode)ModeDropdown.value, Convert.ToSingle(TimeInputField.text), trashnumber);

                LabTools.WriteData(Data, LevelNameInput.text, true);

                Level.ClearOptions();
                LevelDropdown.ClearOptions();

                if (LabTools.GetDataName<RecyclingTaskInputData>() != null)
                {
                //選關卡名稱
                List<string> one = new List<string>();
                    one = LabTools.GetDataName<RecyclingTaskInputData>();
                    for (int i = 0; i < one.Count; i++)
                    {
                        var two = LabTools.GetData<RecyclingTaskInputData>(one[i]);
                        LevelDropdown.options.Add(new Dropdown.OptionData() { text = two.TaskName });
                    }
                }

                if (LabTools.GetDataName<RecyclingTaskInputData>() != null)
                {
                //選關卡名稱
                List<string> one = new List<string>();
                    one = LabTools.GetDataName<RecyclingTaskInputData>();
                    for (int i = 0; i < one.Count; i++)
                    {
                        var two = LabTools.GetData<RecyclingTaskInputData>(one[i]);
                        Level.options.Add(new Dropdown.OptionData() { text = two.TaskName });
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
            temp = LabTools.GetDataName<RecyclingTaskInputData>();
            for (int i = 0; i < temp.Count; i++)
            {
                var Data = LabTools.GetData<RecyclingTaskInputData>(temp[i]);
                if (Data.TaskName == LevelDropdown.captionText.text)
                {
                    LevelNameInput.text = Data.TaskName;
                    ModeDropdown.value = Convert.ToInt32(Data.Mode);
                    TimeInputField.text = Data.Time.ToString();
                    TrashNumber.text = "";
                    for (int j=0; j< Data.Trashnumber.Count; j++)
                        TrashNumber.text += (Data.Trashnumber[j]).ToString() + " ";
                    TrashNumber.text = TrashNumber.text.TrimEnd(' ');
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
}

