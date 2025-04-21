using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Asigna el transform del jugador en el inspector
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 0, -10);  // Ajusta según necesites

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}