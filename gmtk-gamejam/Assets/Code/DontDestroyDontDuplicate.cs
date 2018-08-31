public class DontDestroyDontDuplicate : DontDestroy {

	void Start () {
        base.DoNotDestroyOnLoad();
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

}
