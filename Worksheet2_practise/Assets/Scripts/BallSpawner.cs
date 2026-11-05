
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject mycirclePrefab;
    public float padding = 0.5f;

    void Start()
    {
        Camera cam = Camera.main;

        float xMin = cam.ViewportToWorldPoint(
            new Vector3(0, 0, 0)).x + padding;

        float xMax = cam.ViewportToWorldPoint(
            new Vector3(1, 0, 0)).x - padding;

        float yMin = cam.ViewportToWorldPoint(
            new Vector3(0, 0, 0)).y + padding;

        float yMax = cam.ViewportToWorldPoint(
            new Vector3(0, 1, 0)).y - padding;

        Instantiate(mycirclePrefab,
            new Vector3(xMin, yMin, 0), Quaternion.identity);

        Instantiate(mycirclePrefab,
            new Vector3(xMin, yMax, 0), Quaternion.identity);

        Instantiate(mycirclePrefab,
            new Vector3(xMax, yMin, 0), Quaternion.identity);

        Instantiate(mycirclePrefab,
            new Vector3(xMax, yMax, 0), Quaternion.identity);
    }
}
