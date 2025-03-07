using UnityEngine;

public class NebulaRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
