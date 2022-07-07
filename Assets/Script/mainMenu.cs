using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    
    public void openMenu()
    {
        MainMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void SetMenuOff()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1;

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void CloseGame()
    {
        Application.Quit();
    }

}

