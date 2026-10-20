using UnityEngine;

public class RigidbodyTranslate : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float speed;

    public void MoveTranslate(Vector2 direction)
    {
        if (direction == Vector2.zero)
        {
            _rigidbody2D.linearVelocityX = 0;
            return;
        }

        _rigidbody2D.linearVelocity = new Vector2(speed * direction.x, _rigidbody2D.linearVelocityY);
    }
}
