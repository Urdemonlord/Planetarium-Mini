using UnityEngine;

public class AsteroidSphereRotation : MonoBehaviour
{
    public float rotationSpeed = 5f; // Kecepatan rotasi

    void Update()
    {
        // Rotasi sphere di semua sumbu
        transform.Rotate(new Vector3(0.5f, 1f, 0.3f) * rotationSpeed * Time.deltaTime);
    }
}
