using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    float deathTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (deathTime >= 200) { Destroy(this.gameObject); }
        deathTime++;
    }

    public void Set(UnityEngine.Vector2 velocity, UnityEngine.Vector3 direction) 
    {
        rb.velocity = velocity.normalized * speed;
        transform.rotation = UnityEngine.Quaternion.Euler(direction);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Enemy"))
       {Destroy(this.gameObject); }
    }
}
