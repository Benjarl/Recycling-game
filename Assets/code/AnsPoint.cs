using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnsPoint : MonoBehaviour
{
    public int point = 0;
    public Text pointtext;
    public AudioSource correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointtext.text = point.ToString();
    }

    public void addpoint()
    {
        point++;
        correct.Play();
    }
}
