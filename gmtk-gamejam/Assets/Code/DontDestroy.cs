using UnityEngine;

public class DontDestroy : MonoBehaviour {

    void Awake()
    {
        DoNotDestroyOnLoad();
    }

    protected void DoNotDestroyOnLoad()
    {
        DontDestroyOnLoad(gameObject);
    }
}
