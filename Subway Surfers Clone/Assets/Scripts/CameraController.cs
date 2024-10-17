using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    public Vector3 offset;
    
    void FixedUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
