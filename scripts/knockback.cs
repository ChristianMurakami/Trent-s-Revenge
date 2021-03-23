using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float AttackForce;
    public float Time;
    public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Trent")) 
        {
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null) 
            {
                rb.isKinematic = false;
                UnityEngine.Vector2 move = rb.transform.position - transform.position;
                move = move.normalized * AttackForce;
                rb.AddForce(move, ForceMode2D.Impulse);
                StartCoroutine(TimingCoRoutine(rb));
            }
        }
    }
    private IEnumerator TimingCoRoutine(Rigidbody2D rb) 
    {
        if (rb != null) 
        {
            yield return new WaitForSeconds(Time);
            rb.velocity = Vector2.zero;
            rb.isKinematic = true;
        }
    }
}
