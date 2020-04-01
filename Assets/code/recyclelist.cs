
using System;
using System.Collections;
using System.Collections.Generic;
using GameData;
using UnityEngine;
using UnityEngine.UI;
using LabData;
using System.IO;
using Valve.VR;

namespace TestGameFrame
{
    public class recyclelist : MonoBehaviour
    {
        public static int number = 0;
        public static int day = 1;
        //垃圾編號
        string trashnumber = GameDataManager.FlowData.Trashnumber;
        //需要時間
        int TotalTime = GameDataManager.FlowData.Time;
        public static int i = 0;
        public Text Timedetext;
        public GameObject TimedttextO;
        public int timed = 10;
        public GameObject GamePanel;
        public GameObject EndPanel;
        public Image TrashOne;
        public Image TrashTwo;
        public Text Timelefttext;
        public GameObject TimelefttextO;
        public int tasknum = 0;
        public string now;
        public AudioSource wrongaudio;
        public AudioSource startaudio;
        public GameObject Plaform;
        public GameObject Allobject;
        public GameObject PositionCheck;
        public Text TimeAns;
        public int timewaste = 0;
        public int trashnum = 0;

        public Text UserName;
        public Text Level;
        public Text Mode;
        public Text Rightans;
        public Text Wrongans;
        public Button Back;

        //分數
        public int point = 0;
        public Text pointtext;
        public AudioSource correct;

        private UserData Data;
        string recycle;

        // Start is called before the first frame update
        void Start()
        {
            Wrongans.text = "";
            i = 0;
            for (int j = 0; j < trashnumber.Length; j++)
            {
                if (trashnumber[j] == ' ')
                    tasknum++;
            }
            UserName.text = GameDataManager.FlowData.UserId;
            Level.text = GameDataManager.FlowData.LevelName;
            if (GameDataManager.FlowData.Mode == 0)
                Mode.text = "新手";
            else if (GameDataManager.FlowData.Mode == 1)
                Mode.text = "提示";
            else if (GameDataManager.FlowData.Mode == 2)
                Mode.text = "挑戰";
            //開始倒數
            timed = 10;
            InvokeRepeating("timer", 1, 1);
            startaudio.Play();
            TimedttextO.SetActive(true);
            GamePanel.SetActive(false);
            EndPanel.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void Awake()
        {
            GameEventCenter.AddEvent("wrong", wrong);
            GameEventCenter.AddEvent("reposition", reposition);
            GameEventCenter.AddEvent("changenum", changenum);
            GameEventCenter.AddEvent("timecosttext", timecosttext);
            GameEventCenter.AddEvent("addpoint", addpoint);
        }

        void timer()
        {
            Allobject.transform.position = PositionCheck.transform.position + new Vector3(0f, 0f, 0.68f);
            timed--;
            Timedetext.text = "距離遊戲開始還有" + timed + "秒請將手把移至視線範圍內";

            if (timed == 0)
            {
                CancelInvoke("timer");
                TimedttextO.SetActive(false);
                GamePanel.SetActive(true);
                changenum();
                if (GameDataManager.FlowData.Mode > 0)
                {
                    TimelefttextO.SetActive(true);
                    InvokeRepeating("timeleft", 1, 1);
                }
                else
                    TimelefttextO.SetActive(false);
            }
        }

        void timeleft()
        {
            TotalTime--;
            Timelefttext.text = "剩餘時間:" + TotalTime + "秒";
            if (TotalTime == 0)
            {
                CancelInvoke("timeleft");
                end();
            }
        }

        public void changenum()  //換回收物與日期
        {
            if (!Char.IsNumber(trashnumber, i))
            {
                i++;
            }
            if (i == trashnumber.Length)
            {
                end();
            }
            else
            {
                number = 0;
                while (Char.IsNumber(trashnumber, i))
                {
                    number = number * 10 + trashnumber[i] - 48;
                    i++;
                }
                System.Random rand = new System.Random();
                day = rand.Next(1, 7);
                recyclelisttext Recyclelisttext = FindObjectOfType<recyclelisttext>();
                Recyclelisttext.recycletext(number);
                Recyclelisttext.recycleday(day);
                changetag(number);
                GameObject.Find("Trash." + number).transform.position = Plaform.transform.position + new Vector3(0f, 0.1f, 0f);
                InvokeRepeating("timecost", 1, 1);
            }
        }
        //答題時間
        void timecost()
        {
            timewaste++;
        }

        public void wrong()  //錯誤題號
        {
            Wrongans.text = Wrongans.text + number + ' ';
            wrongaudio.Play();
        }

        void end()  //結算
        {
            Back.onClick.AddListener(delegate
            {
                GameSceneManager.Instance.Change2MainUI();
            });

            Rightans.text = point + "/" + tasknum;
            GamePanel.SetActive(false);
            EndPanel.SetActive(true);

            //存檔
            Data = new UserData(UserName.text, Level.text, Mode.text, Rightans.text, Wrongans.text, TimeAns.text);
            GameDataManager.LabDataManager.SendData(Data);
        }

        void changetag(int number)  //分類
        {
            TrashOne = GameObject.Find("TrashImageOne").GetComponent<Image>();
            TrashTwo = GameObject.Find("TrashImageTwo").GetComponent<Image>();

            if (1 <= number && number <= 9)
            {
                TrashOne.color = new Color32(0, 255, 0, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (10 <= number && number <= 12)
            {
                TrashOne.color = new Color32(0, 0, 255, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (13 <= number && number <= 20)
            {
                TrashOne.color = new Color32(0, 0, 255, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (21 <= number && number <= 28)
            {
                TrashOne.color = new Color32(0, 0, 255, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (29 <= number && number <= 33)
            {
                TrashOne.color = new Color32(0, 0, 255, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (34 <= number && number <= 41)
            {
                TrashOne.color = new Color32(0, 255, 0, 225);
                TrashTwo.color = new Color32(0, 0, 255, 225);
            }

            else if (42 <= number && number <= 43)
            {
                TrashOne.color = new Color32(0, 0, 255, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (44 <= number && number <= 54)
            {
                TrashOne.color = new Color32(0, 0, 255, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }

            else if (55 <= number && number <= 59)
            {
                TrashOne.color = new Color32(0, 225, 0, 225);
                TrashTwo.color = new Color32(0, 0, 255, 225);
            }

            else
            {
                TrashOne.color = new Color32(0, 0, 0, 225);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }
            if (GameDataManager.FlowData.Mode > 0)
            {
                TrashOne.color = new Color32(0, 225, 0, 0);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }
        }
        //重製位置 重製答題時間
        public void reposition()
        {
            GameObject.Find("Trash." + number).transform.position = Plaform.transform.position + new Vector3(-2f, 0.1f, 0f);
            CancelInvoke("timecost");
            TimeAns.text = TimeAns.text + timewaste + '秒' + '\n';
            timewaste = 0;
        }

        //答題間隔
        public void timecosttext()
        {
            trashnum++;
            TimeAns.text = TimeAns.text + trashnum + '.' + number + ':' + recyclelisttext.recyclething.text + ' ';
        }

        //加分
        public void addpoint()
        {
            point++;
            correct.Play();
            pointtext.text = point.ToString();
        }
    }
}
