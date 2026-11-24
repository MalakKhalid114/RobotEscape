using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
}