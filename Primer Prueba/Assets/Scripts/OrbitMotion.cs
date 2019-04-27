using UnityEngine;

public class OrbitMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 90 * Time.deltaTime);
    }
}
