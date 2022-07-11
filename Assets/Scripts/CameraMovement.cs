using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 0.125f;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mainPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, mainPosition, speed);
        transform.position = smoothPosition;
    }
}