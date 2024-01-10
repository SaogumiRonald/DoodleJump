using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel;
    public void ResumeGame()
    {
        Time.timeScale = 1f; 
        panel.SetActive(false); 
    }



public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
