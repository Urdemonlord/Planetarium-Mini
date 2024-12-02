using UnityEngine;

public class IndividualAsteroidRotation : MonoBehaviour
{
    public float rotationSpeed = 15f; // Kecepatan rotasi per asteroid
    private Vector3 rotationAxis;

    void Start()
    {
        // Pilih sumbu rotasi acak untuk asteroid ini
        rotationAxis = Random.onUnitSphere;
    }

    void Update()
    {
        // Rotasi pada sumbu acak
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
