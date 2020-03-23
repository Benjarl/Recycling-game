using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestGameFrame
{
    public class triggerAppliance : MonoBehaviour
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
                if (other.gameObject.tag == "電器類")
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
