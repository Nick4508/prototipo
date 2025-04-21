using UnityEngine;
using UnityEngine.UI;

public class TimeDisplayFinalScene : MonoBehaviour
{
    public Text timeText; // Asigna tu UI Text aquí en el inspector

    void Start()
    {
        // Verifica si existe el tracker
        if (PersistentTimeTracker.Instance != null)
        {
            timeText.text = "Tiempo: " + PersistentTimeTracker.Instance.GetCurrentTime();
        }
        else
        {
            timeText.text = "Tiempo: 00:00";
        }
    }
}