using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTrash : MonoBehaviour
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
            if (other.gameObject.tag == "不可回收")
            {
                AnsPoint ansPoint = FindObjectOfType<AnsPoint>();
                ansPoint.addpoint();
            }
            else
            {
                Recyclelist.wrong();
            }
            Recyclelist.reposition();
            Recyclelist.changenum();
            
            other.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
        
    }
}
