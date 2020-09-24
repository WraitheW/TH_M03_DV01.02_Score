using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadGame : MonoBehaviour
{
   public void restartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
