using System;
using System.Collections;
using System.Collections.Generic;
using GameData;
using UnityEngine;
using UnityEngine.UI;
using LabData;
using System.IO;
using Valve.VR;
using Mindfrog.Recycling;

namespace TestGameFrame
{
    public class recyclelist : MonoBehaviour
    {
        public static int number = 0;
        public static int day = 1;
        //垃圾編號
        List<int> trashnumber = GameDataManager.FlowData.TaskData.Trashnumbers;
        //需要時間
        float TotalTime = GameDataManager.FlowData.TaskData.LimitTime;
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
        public string now;
        public AudioSource wrongaudio;
        public AudioSource startaudio;
        public GameObject Plaform;
        public GameObject Allobject;
        public GameObject PositionCheck;
        public Text TimeAns;
        public int timewaste = 0;
        public int Totaltimewaste = 0;
        public int trashnum = 0;
        public bool issuccess = true;

        List<RecyclingGarbage> garbage = new List<RecyclingGarbage>();

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

        private RecyclingGarbage GData;
        private RecyclingScopeOutput RData;
        string recycle;

        // Start is called before the first frame update
        void Start()
        {
            Wrongans.text = "";
            i = 0;
            UserName.text = GameDataManager.FlowData.UserId;
           Level.text ="";
            if (Convert.ToInt32(GameDataManager.FlowData.TaskData.GameDifficulty) == 0)
                Mode.text = "新手";
            else if (Convert.ToInt32(GameDataManager.FlowData.TaskData.GameDifficulty) == 1)
                Mode.text = "提示";
            else if (Convert.ToInt32(GameDataManager.FlowData.TaskData.GameDifficulty) == 2)
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
                if (GameDataManager.FlowData.TaskData.GameDifficulty > 0)
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
            if (i >= trashnumber.Count)
            {
                end();
            }
            else
            {
                number = trashnumber[i];
                i++;
                System.Random rand = new System.Random();
                day = rand.Next(1, 7);
                recyclelisttext Recyclelisttext = FindObjectOfType<recyclelisttext>();
                Recyclelisttext.recycletext(number);
                Recyclelisttext.recycleday(day);
                changetag(number);
                GameObject.Find("Trash." + number+"(Clone)").transform.position = Plaform.transform.position + new Vector3(0f, 0.1f, 0f);
                InvokeRepeating("timecost", 1, 1);
            }
        }
        //答題時間
        void timecost()
        {
            timewaste++;
            Totaltimewaste++;
        }

        void end()  //結算
        {
            Back.onClick.AddListener(delegate
            {
                GameApplication.Instance.GameApplicationDispose();
                Application.Quit();
            });

            Rightans.text = point + "/" + trashnumber.Count;
            GamePanel.SetActive(false);
            EndPanel.SetActive(true);

            //存檔
            RData = new RecyclingScopeOutput() {
                CorrectRate = Convert.ToSingle(point / trashnumber.Count),
                AverageTime = Convert.ToSingle(Totaltimewaste / trashnumber.Count),
                Garbages = garbage,
            };
            GameDataManager.LabDataManager.SendData(RData);
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
            if (GameDataManager.FlowData.TaskData.GameDifficulty > 0)
            {
                TrashOne.color = new Color32(0, 225, 0, 0);
                TrashTwo.color = new Color32(0, 0, 255, 0);
            }
        }
        //重製位置 重製答題時間
        public void reposition()
        {
            GameObject.Find("Trash." + number + "(Clone)").transform.position = Plaform.transform.position + new Vector3(-2f, 0.1f, 2f);
            CancelInvoke("timecost");
            TimeAns.text = TimeAns.text + timewaste + '秒' + '\n';
            GData = new RecyclingGarbage() { 
                GarbageIDP=number,
                IsSuccess=issuccess,
                TimeToUse=(float)timewaste
            };
            garbage.Add(GData);
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
            issuccess = true;
        }

        public void wrong()  //錯誤題號
        {
            Wrongans.text = Wrongans.text + number + ' ';
            wrongaudio.Play();
            issuccess = false;
        }
    }
}
