using UnityEngine;


namespace ProtoFramework
{
    public class Game : MonoBehaviour
    {
        public static void Pause(bool pauseAdioListener = true)
        {
            Time.timeScale = 0;
            AudioListener.pause = pauseAdioListener;
        }

        public static void Resume(bool pauseAdioListener = false)
        {
            Time.timeScale = 1;
            AudioListener.pause = pauseAdioListener;
        }
    }
}
