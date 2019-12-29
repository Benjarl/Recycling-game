using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (other.gameObject.name == "Cube")
        {
            recyclelist Recyclelist = FindObjectOfType<recyclelist>();
            if(other.gameObject.tag == "紙類")
            {
                if (recyclelist.day == 1 || recyclelist.day == 5)
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
            Recyclelist.reposition();
            other.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
            
    }
}
