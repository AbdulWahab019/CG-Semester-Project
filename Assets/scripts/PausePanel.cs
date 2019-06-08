using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
     public GameObject pausePanel;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {

        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }


    //Reloads the Level
    public void Replay()
    {
        SceneManager.LoadScene("Scene1");
    }

    //controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        pausePanel.gameObject.SetActive(true);
        
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        pausePanel.gameObject.SetActive(false);
    }

    //loads inputted level
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
