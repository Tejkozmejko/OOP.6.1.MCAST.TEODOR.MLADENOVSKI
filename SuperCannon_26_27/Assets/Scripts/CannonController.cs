using UnityEngine;

public class CannonController : MonoBehaviour
{
    [SerializeField] float maxCannonAngle = 40f;

    Quaternion minAngle, maxAngle;

    void Start()
    {
        minAngle = Quaternion.Euler(0f, 0f, -maxCannonAngle);
        maxAngle = Quaternion.Euler(0f, 0f, maxCannonAngle);
    }

    void FixedUpdate()
    {
        PointAtMouse();
    }

    private void PointAtMouse()
    {
        Camera myCamera = Camera.main;
        if (myCamera == null) return;

        Vector3 mousePos = myCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 relativePos = (Vector2)(mousePos - transform.position);

        // Cannon sprite points up at 0 degrees. Rotate only on the 2D Z axis.
        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg - 90f;
        angle = Mathf.Clamp(angle, -maxCannonAngle, maxCannonAngle);

        Quaternion newrotation = Quaternion.Euler(0f, 0f, angle);
        transform.rotation = newrotation;
    }
}
