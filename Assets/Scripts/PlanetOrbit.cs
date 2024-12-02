using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform centerObject; // Objek pusat orbit (matahari)
    public float orbitSpeed = 10f; // Kecepatan orbit planet
    public float orbitRadius = 5f; // Jarak orbit dari pusat

    private Vector3 orbitAxis = Vector3.up; // Arah rotasi (sumbu Y)

    void Start()
    {
        // Awal posisi planet, diatur sesuai radius orbit
        if (centerObject != null)
        {
            Vector3 initialPosition = transform.position - centerObject.position;
            initialPosition = initialPosition.normalized * orbitRadius;
            transform.position = centerObject.position + initialPosition;
        }
    }

    void Update()
    {
        if (centerObject != null)
        {
            // Rotasi planet mengelilingi objek pusat
            transform.RotateAround(centerObject.position, orbitAxis, orbitSpeed * Time.deltaTime);

            // Pastikan planet tetap pada radius orbit
            Vector3 desiredPosition = (transform.position - centerObject.position).normalized * orbitRadius + centerObject.position;
            transform.position = desiredPosition;
        }
    }
}
