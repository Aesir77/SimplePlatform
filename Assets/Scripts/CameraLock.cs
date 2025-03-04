using UnityEngine;

public class CameraLock : MonoBehaviour
{
    [SerializeField] Transform cameraLock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (cameraLock.position.x, transform.position.y, cameraLock.position.z);
    }
}
