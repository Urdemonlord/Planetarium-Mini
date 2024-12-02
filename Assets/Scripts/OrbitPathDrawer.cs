using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitPathDrawer : MonoBehaviour
{
    public Transform centerObject;  // Objek pusat orbit (Matahari)
    public float radius = 5f;       // Radius orbit
    public int segments = 100;      // Jumlah segmen untuk membuat lingkaran

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1; // +1 untuk menutup lingkaran
        lineRenderer.useWorldSpace = true;

        // Konfigurasi warna dan lebar
        lineRenderer.startWidth = 0.02f;
        lineRenderer.endWidth = 0.02f;
        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.white;

        DrawOrbit();
    }

    void DrawOrbit()
    {
        float angle = 0f;
        for (int i = 0; i <= segments; i++)
        {
            float x = centerObject.position.x + Mathf.Cos(angle) * radius;
            float z = centerObject.position.z + Mathf.Sin(angle) * radius;

            lineRenderer.SetPosition(i, new Vector3(x, centerObject.position.y, z));
            angle += 2 * Mathf.PI / segments;
        }
    }
}
