using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PersistentTimeTracker : MonoBehaviour
{
    public static PersistentTimeTracker Instance;
    private float gameStartTime;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            gameStartTime = Time.time;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Método público para obtener el tiempo formateado
    public string GetCurrentTime()
    {
        float currentTime = Time.time - gameStartTime;
        int minutes = (int)(currentTime / 60);
        int seconds = (int)(currentTime % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}