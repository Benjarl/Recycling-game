using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cantrecycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void norecycle() //不可回收
    {
        recyclelist Recyclelist = FindObjectOfType<recyclelist>();
        if (GameObject.Find("Cube").tag == "不可回收")
        {
            AnsPoint ansPoint = FindObjectOfType<AnsPoint>();
            ansPoint.addpoint();
        }
        else
        {
            Recyclelist.wrong();
        }
        Recyclelist.changenum();
        GameObject.Find("Cube").transform.position = new Vector3(0.0f, 4.5f, 0.0f);
    }

    public void norecycletoday() //今日不可回收
    {
        recyclelist Recyclelist = FindObjectOfType<recyclelist>();
        if (recyclelist.day == 3 || recyclelist.day == 7)
        {
            if (GameObject.Find("Cube").tag != "不可回收")
            {
                AnsPoint ansPoint = FindObjectOfType<AnsPoint>();
                ansPoint.addpoint();
            }
            else
            {
                Recyclelist.wrong();
            }
        }

        else if(GameObject.Find("Cube").tag == "紙類" || GameObject.Find("Cube").tag == "舊衣")
        {
            if (recyclelist.day == 2 || recyclelist.day == 4 || recyclelist.day == 6)
            {
                AnsPoint ansPoint = FindObjectOfType<AnsPoint>();
                ansPoint.addpoint();
            }
            else
            {
                Recyclelist.wrong();
            }
        }

        else if(GameObject.Find("Cube").tag == "紙容器" || GameObject.Find("Cube").tag == "塑膠類" || GameObject.Find("Cube").tag == "玻璃類" || GameObject.Find("Cube").tag == "鐵鋁罐" || GameObject.Find("Cube").tag == "保麗龍" || GameObject.Find("Cube").tag == "電器類")
        {
            if(recyclelist.day == 1 || recyclelist.day ==5)
            {
                AnsPoint ansPoint = FindObjectOfType<AnsPoint>();
                ansPoint.addpoint();
            }
            else
            {
                Recyclelist.wrong();
            }
        }
        else
        {
            Recyclelist.wrong();
        }

        Recyclelist.changenum();
        GameObject.Find("Cube").transform.position = new Vector3(0.0f, 4.5f, 0.0f);
    }
}
