using UnityEngine;

public class HurtBehaviour : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField] private float forcePower;

    private void Awake() { _rb = GetComponent<Rigidbody>(); }
    public void Hurt() => _rb.AddForce(Vector3.up * forcePower);
}