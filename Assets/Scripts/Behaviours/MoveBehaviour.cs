using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField] private float speed;

    private void Awake() { _rb = GetComponent<Rigidbody>(); }
    public void Move(Vector3 direction)
    {
        Vector3 velocity = direction * speed;
        velocity.y = _rb.linearVelocity.y;
        _rb.linearVelocity = velocity;
    }
}