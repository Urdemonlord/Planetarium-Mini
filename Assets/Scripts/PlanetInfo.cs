using UnityEngine;

public class PlanetInfo : MonoBehaviour
{
    public string planetName;
    public string description;

    void OnMouseDown()
    {
        Debug.Log($"{planetName}: {description}");
    }
}
