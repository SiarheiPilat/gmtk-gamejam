using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCondition : MonoBehaviour {

    public bool tracking;
    GameObject[] enemies;
    public string nextLevel;


	// Use this for initialization
	void Start () {
		
	}
	
    // Update is called once per frame
	void Update () {
        if (tracking)
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");
            if(enemies.Length == 0)
            {
                Win();
            }
        }	
	}

    void Win()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel);
    }
}
