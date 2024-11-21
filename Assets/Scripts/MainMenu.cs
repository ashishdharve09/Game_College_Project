using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject levelPanel;
    public GameObject optionsPanel;
    public GameObject MainPanel;

    public void PlayButton()
    {
        levelPanel.SetActive(true);
        MainPanel.SetActive(false);
    }
    public void OptionsButton()
    {
        optionsPanel.SetActive(true);
        MainPanel.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Quitgame");
        Application.Quit();
    }
     public void CloseLevelPanel()
    {
        levelPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void CloseOptionsPanel()
    {
        optionsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
}
