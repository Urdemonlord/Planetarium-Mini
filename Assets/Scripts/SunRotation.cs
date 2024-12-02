using UnityEngine;

public class SunRotation : MonoBehaviour
{
    public float rotationSpeed = 5f; // Kecepatan rotasi matahari

    void Update()
    {
        // Rotasi matahari pada sumbu Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
