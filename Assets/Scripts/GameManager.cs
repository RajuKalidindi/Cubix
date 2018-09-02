using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool GameEnd = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true); 
    }

    public void GameOver()
    {
        if (GameEnd == false)
        {
            GameEnd = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }      
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
