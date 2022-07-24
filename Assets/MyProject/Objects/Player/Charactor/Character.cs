using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody characterRB;

    private float _isJump = 0;

    private void FixedUpdate()
    {
        if (_isJump > 0)
        {   _isJump -= Time.deltaTime;}
    }

    public void JumpCharacter(float jumpSpeed)
    {
        if (_isJump <= 0)
        {
            characterRB.AddForce(0f, jumpSpeed, 0f, ForceMode.Impulse);
            _isJump += 0.05f;
        }
    }
}
