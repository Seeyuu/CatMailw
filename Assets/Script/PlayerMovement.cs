using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rigidbody;
    private Vector3 change;
    private Animator anim;

    public LayerMask SolidObject;
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (IsWalkable(transform.position + change))
        {
            UpdateAnimationAndMove();
        }
    }

    private void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
            anim.SetBool("moving", true);

        }
        else
        {
            anim.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        rigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

    private bool IsWalkable(Vector3 targetPos)
    {
        // Check if the target position is walkable by performing a Physics2D.OverlapCircle check
        if (Physics2D.OverlapCircle(targetPos, 0.2f, SolidObject) != null)
        {
            return false;
        }
        return true;
    }


}
