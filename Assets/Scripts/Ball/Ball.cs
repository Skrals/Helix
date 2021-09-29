using UnityEngine;

public class Ball : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if( other.TryGetComponent(out PlatformSegment platformSegment))
        {
            other.GetComponentInParent<Platform>().Break();
        }
    }
}
