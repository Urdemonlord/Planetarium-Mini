using UnityEngine;

public class AsteroidBeltRotation : MonoBehaviour
{
    public float rotationSpeed = 10f; // Kecepatan rotasi dalam derajat per detik

    void Update()
    {
        // Rotasi belt di sekitar sumbu Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
