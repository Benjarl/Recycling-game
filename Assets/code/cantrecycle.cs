using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestGameFrame
{
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

        public void norecycletoday() //今日不可回收
        {
            if (recyclelist.day == 3 || recyclelist.day == 7)
            {
                if (GameObject.Find("Trash." + recyclelist.number).tag != "不可回收")
                {
                    GameEventCenter.DispatchEvent("addpoint");
                }
                else
                {
                    GameEventCenter.DispatchEvent("wrong");
                }
            }

            else if (GameObject.Find("Trash." + recyclelist.number).tag == "紙類")
            {
                if (recyclelist.day == 2 || recyclelist.day == 4 || recyclelist.day == 6)
                {
                    GameEventCenter.DispatchEvent("addpoint");
                }
                else
                {
                    GameEventCenter.DispatchEvent("wrong");
                }
            }

            else if (GameObject.Find("Trash." + recyclelist.number).tag == "紙容器" || GameObject.Find("Trash." + recyclelist.number).tag == "塑膠類" || GameObject.Find("Trash." + recyclelist.number).tag == "玻璃類" || GameObject.Find("Trash." + recyclelist.number).tag == "鐵鋁罐" || GameObject.Find("Trash." + recyclelist.number).tag == "保麗龍" || GameObject.Find("Trash." + recyclelist.number).tag == "電器類")
            {
                if (recyclelist.day == 1 || recyclelist.day == 5)
                {
                    GameEventCenter.DispatchEvent("addpoint");
                }
                else
                {
                    GameEventCenter.DispatchEvent("wrong");
                }
            }
            else
            {
                GameEventCenter.DispatchEvent("wrong");
            }
            GameEventCenter.DispatchEvent("reposition");
            GameEventCenter.DispatchEvent("changenum");
        }
    }
}
