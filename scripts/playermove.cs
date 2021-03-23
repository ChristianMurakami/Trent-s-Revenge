using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public enum PlayState 
{
    Idle,
    Walk,
    Attack
}
public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 4f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 Move;
    public PlayState currentState = PlayState.Idle;

    // Update is called once per frame
    void Update()
    {
        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("attack") &&  currentState != PlayState.Attack) 
        {
            StartCoroutine(AttackCo());
        }
        animator.SetFloat("Horizontal", Move.x);
        animator.SetFloat("Vertical", Move.y);
        animator.SetFloat("Speed", Move.sqrMagnitude);
    }
    private IEnumerator AttackCo() 
    {
        animator.SetBool("Attacking", true);
        currentState = PlayState.Attack;
        yield return null;
        animator.SetBool("Attacking", false);
        yield return new WaitForSeconds(.3f);
        currentState = PlayState.Walk;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Move * MovementSpeed * Time.fixedDeltaTime);
    }
}
