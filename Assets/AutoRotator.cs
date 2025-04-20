using UnityEngine;

public class AutoRotator : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 50f, 0); // Rotation speed on X, Y, Z axes in degrees per second

    void Update()
    {
        // Automatically rotate the object
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
