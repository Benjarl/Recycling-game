using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TestGameFrame
{
    public class triggerPapper : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name[5] == '.')
            {
                if (other.gameObject.tag == "紙類")
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
                other.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }

        }
    }
}
