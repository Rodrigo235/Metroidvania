using UnityEngine;

public class AnimationTansitionSystem : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Animator _animator;

    // Update is called once per frame
    void Update()
    {
        if (!IsJumping())
        {
            if (!IsRunning())
            {
                _animator.SetInteger("transition", AnimationTransitionValues.IDLE);
            } 
            else
            {
                _animator.SetInteger("transition", AnimationTransitionValues.WALK);
            }
        }
        else
        {
            _animator.SetInteger("transition", AnimationTransitionValues.JUMP);
        }
    }

    private bool IsRunning()
    {
        if (_rigidbody2D.linearVelocityX != 0) return true;

        return false;
    }

    private bool IsJumping()
    {
        if (_rigidbody2D.linearVelocityY != 0) return true;

        return false;
    }
}
