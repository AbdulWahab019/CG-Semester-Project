using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panelChange : MonoBehaviour
{
    public GameObject InstructionPanel;
    public GameObject LevelPanel;
    public GameObject m;
    int counter2;
    int counter;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void ShowInstructions()
    {
        counter++;

        if (counter % 2 == 1)
        {
            InstructionPanel.gameObject.SetActive(true);
            m.gameObject.SetActive(true);
        }
        else
        {
            InstructionPanel.gameObject.SetActive(false);
            m.gameObject.SetActive(false);
        }
    }
    public void ShowLevels()
    {
        counter2++;

        if (counter2 % 2 == 1)
        {
            LevelPanel.gameObject.SetActive(true);
        }
        else
        {
            LevelPanel.gameObject.SetActive(false);
        }
    }

}
 

