using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float jumpForce;

    public void OnJump()
    {
        _rigidbody2D.linearVelocity = new Vector2(_rigidbody2D.linearVelocityX, jumpForce);
    }


}
