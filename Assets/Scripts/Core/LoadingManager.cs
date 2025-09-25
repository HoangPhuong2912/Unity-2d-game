using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private void Awake()
    {
        int loadLevel = PlayerPrefs.GetInt("loadingLevel", 1);

        // đảm bảo không vượt quá build index
        if (loadLevel >= SceneManager.sceneCountInBuildSettings)
            loadLevel = 1;

        SceneManager.LoadScene(loadLevel);
    }

}
