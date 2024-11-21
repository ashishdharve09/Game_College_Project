using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameClearedUI;
    public bool isGameOver = false;
    public bool isGameCleared = false;
    public TMP_Text gameOverText;
    public TMP_Text gameClearedText;
    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
        isGameOver = true;
    }
    public void GameCleared()
    {
        gameClearedUI.SetActive(true);
        Time.timeScale = 0;
        isGameCleared = true;
    }

    


}
