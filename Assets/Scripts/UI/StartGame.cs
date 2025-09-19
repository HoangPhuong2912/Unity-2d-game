using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void GameStart()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("currentLevel", 1);
        PlayerPrefs.SetInt("loadingLevel", 1);

        GameEvents.instance.gameStarted.SetValueAndForceNotify(true);
    }
}