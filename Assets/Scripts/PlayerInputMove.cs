using UnityEngine;

public class PlayerInputMove : MonoBehaviour
{
    [SerializeField] private RigidbodyTranslate _rigidbodyTranslate;
    private Vector2 _direction;

    private void Update()
    {
        if (_rigidbodyTranslate == null) return;

        if(_direction.x < 0)
        {
            transform.parent.localScale = new Vector3(-1, 1, 1);
        }
        else if (_direction.x > 0)
        {
            transform.parent.localScale = new Vector3(1, 1, 1);
        }

        _rigidbodyTranslate.MoveTranslate(_direction);
    }

    public void SetPlayerDirection(Vector2 direction)
    {
        _direction = direction;
    }
}
