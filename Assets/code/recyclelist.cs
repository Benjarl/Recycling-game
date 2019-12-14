using System;
using System.Collections;
using System.Collections.Generic;
using GameData;
using UnityEngine;
using UnityEngine.UI;
using LabData;

public class recyclelist : MonoBehaviour
{
    public static int number = 0;
    public static int day = 1;
    string trashnumber = GameDataManager.Instance.NowTaskData.Trashnumber;
    int TotalTime = GameDataManager.Instance.NowTaskData.Time;
    public static int i = 0;
    public Text Timedetext;
    public GameObject TimedttextO;
    public int timed = 3;
    public GameObject GamePanel;
    public GameObject EndPanel;
    public GameObject Trash;
    public Image TrashOne;
    public Image TrashTwo;
    public Text Timelefttext;
    public GameObject TimelefttextO;
    public int tasknum = 0;

    public Text UserName;
    public Text Level;
    public Text Mode;
    public Text Rightans;
    public Text Wrongans;
    public Button Back;

    // Start is called before the first frame update
    void Start()
    {
        Wrongans.text = "";
        i = 0;
        for(int j=0;j< trashnumber.Length;j++)
        {
            if (trashnumber[j] == ' ')
                tasknum++;
        }
        Level.text = GameDataManager.Instance.NowTaskData.LevelName;
        if (GameDataManager.Instance.NowTaskData.Mode == 0)
            Mode.text = "新手";
        else if (GameDataManager.Instance.NowTaskData.Mode == 1)
            Mode.text = "提示";
        else if (GameDataManager.Instance.NowTaskData.Mode == 2)
            Mode.text = "挑戰";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void timede() //開始倒數
    {
        timed = 3;
        InvokeRepeating("timer", 1, 1);
        TimedttextO.SetActive(true);
        GamePanel.SetActive(false);
        EndPanel.SetActive(false);
        Trash.SetActive(false);
    }

    void timer()
    {
        timed--;
        Timedetext.text = timed + "";

        if (timed == 0)
        {
            CancelInvoke("timer");
            TimedttextO.SetActive(false);
            GamePanel.SetActive(true);
            Trash.SetActive(true);
            changenum();
            if(GameDataManager.Instance.NowTaskData.Mode > 0)
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
        if(TotalTime == 0)
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
                number = number * 10 + trashnumber[i]-48;
                i++;
            }
            System.Random rand = new System.Random();
            day = rand.Next(1, 7);
            recyclelisttext Recyclelisttext = FindObjectOfType<recyclelisttext>();
            Recyclelisttext.recycletext(number);
            Recyclelisttext.recycleday(day);
            changetag(number);
        }
        
    }

    public void wrong()  //錯誤題號
    {
        Wrongans.text = Wrongans.text + number + ' ';
    }

    void end()  //結算
    {
        Back.onClick.AddListener(delegate
        {
            GameSceneManager.Instance.ChangeScene(new List<Action>()
            {
                GameUIManager.Instance.StartMainUiLogic
            }, GobalData.MainUiScene);
        });
        AnsPoint ansPoint = FindObjectOfType<AnsPoint>();
        Rightans.text = ansPoint.point + "/" + tasknum;
        GamePanel.SetActive(false);
        EndPanel.SetActive(true);
        Trash.SetActive(false);
    }

    void changetag(int number)  //分類
    {
        TrashOne = GameObject.Find("TrashImageOne").GetComponent<Image>();
        TrashTwo = GameObject.Find("TrashImageTwo").GetComponent<Image>();

        if (1 <= number && number <= 9)
        {
            GameObject.Find("Cube").tag = "紙類";
            TrashOne.color = new Color32(0, 255, 0, 225);
        }

        else if (10 <= number && number <= 12)
        {
            GameObject.Find("Cube").tag = "紙容器類";
            TrashOne.color = new Color32(0, 0, 255, 225);
        }

        else if (13 <= number && number <= 20)
        {
            GameObject.Find("Cube").tag = "塑膠類";
            TrashOne.color = new Color32(0, 0, 255, 225);
        }

        else if (21 <= number && number <= 28)
        {
            GameObject.Find("Cube").tag = "玻璃類";
            TrashOne.color = new Color32(0, 0, 255, 225);
        }

        else if (29 <= number && number <= 30)
        {
            GameObject.Find("Cube").tag = "鐵鋁罐類";
            TrashOne.color = new Color32(0, 0, 255, 225);
        }

        else if (31 <= number && number <= 33)
        {
            GameObject.Find("Cube").tag = "舊衣類";
            TrashOne.color = new Color32(0, 255, 0, 225);
        }

        else if (34 <= number && number <= 41)
        {
            GameObject.Find("Cube").tag = "電池類";
            TrashOne.color = new Color32(0, 255, 0, 225);
            TrashTwo.color = new Color32(0, 0, 255, 225);
        }

        else if (42 <= number && number <= 43)
        {
            GameObject.Find("Cube").tag = "保麗龍類";
            TrashOne.color = new Color32(0, 0, 255, 225);
        }

        else if (44 <= number && number <= 54)
        {
            GameObject.Find("Cube").tag = "電器類";
            TrashOne.color = new Color32(0, 0, 255, 225);
        }

        else if (55 <= number && number <= 59)
        {
            GameObject.Find("Cube").tag = "燈光類";
            TrashOne.color = new Color32(0, 225, 0, 225);
            TrashTwo.color = new Color32(0, 0, 255, 225);
        }

        else
        {
            GameObject.Find("Cube").tag = "不可回收";
            TrashOne.color = new Color32(0, 0, 0, 225);
        }
        if (GameDataManager.Instance.NowTaskData.Mode > 0)
        {
            TrashOne.color = new Color32(0, 225, 0, 0);
            TrashTwo.color = new Color32(0, 0, 255, 0);
        }
    }
}
