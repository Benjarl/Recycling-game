using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CreatUI : MonoBehaviour
{
    public InputField LevelNameInput;

    public Dropdown ModeDropdown;

    public InputField TimeInputField;

    public Button ChooseTrashButton;

    public Button BackButton;

    public Button SaveButton;

    //Panel
    public GameObject SetLevelPanel;

    public GameObject CreatePanel;

    public GameObject TrashPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartchangePanel()
    {
        ChooseTrashButton.onClick.AddListener(delegate
        {
            CreatePanel.SetActive(false);
            TrashPanel.SetActive(true); 
        });

        BackButton.onClick.AddListener(delegate
        {
            CreatePanel.SetActive(false);
            SetLevelPanel.SetActive(true);
        });

        if (SetUI.set == "New")
            Startnew();

        else if (SetUI.set == "Change")
            Startchange();
    }

    public void Startnew()
    {

    }

    public void Startchange()
    {

    }
}
