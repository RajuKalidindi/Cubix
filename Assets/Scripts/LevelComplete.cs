using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 
}
