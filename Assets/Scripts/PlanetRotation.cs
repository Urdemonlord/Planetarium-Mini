using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Kecepatan rotasi planet pada porosnya

    void Update()
    {
        // Rotasi planet pada poros Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
