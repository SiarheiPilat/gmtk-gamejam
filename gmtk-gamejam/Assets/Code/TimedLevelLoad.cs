using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLevelLoad : MonoBehaviour {


    private float timer;
    public string NextLevel;

	// Use this for initialization
	void Start () {
        timer = 0.0f;	
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(timer);

        timer += Time.deltaTime;

        if(timer > 25.0f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(NextLevel);
        }
	}
}
