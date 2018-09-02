using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    public void LoadLevel (string name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }

}
