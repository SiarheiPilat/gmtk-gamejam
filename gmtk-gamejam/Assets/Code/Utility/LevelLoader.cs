using UnityEngine;
using UnityEngine.SceneManagement;

    public class LevelLoader : MonoBehaviour
    {
        public void GoToScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
