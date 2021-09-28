using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class BallJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out PlatformSegment segment))
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
