using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float moveSpeed;
   public bool isMoving;
   public Vector2 input;
   private Animator animator;

   public LayerMask SolidObjectLayer;
   
   
   private void Awake(){
        animator = GetComponent<Animator>();
   }

   private void Update(){
    if(!isMoving){
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        
        

        if(input.x != 0) input.y = 0;

        if(input != Vector2.zero){

            animator.SetFloat("MoveX", input.x);
            animator.SetFloat("MoveY", input.y);

            var targetPos = transform.position;
            targetPos.x += input.x;
            targetPos.y += input.y;

            if(IsWalkable(targetPos))
                StartCoroutine(Move(targetPos));
        }
    }
    animator.SetBool("isMoving", isMoving);
   }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }

    public bool IsWalkable(Vector3 targetPos){
        if(Physics2D.OverlapCircle(targetPos, 0.2f, SolidObjectLayer) != null){
            return false;
        }
        return true;
    }

    //cant move when read the sign

    // Add this method to your PlayerController script
    

}
