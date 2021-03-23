using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public string EnemyName;
    public int Heatlh;
    public int Attack;
    public float Speed;
    public Transform Target;
    public float attackArea;
    public float chaseArea;
    public Transform Home;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindWithTag("Trent").transform;
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
    }

    void checkDistance() 
    {
        if (Vector2.Distance(Target.position, transform.position) <= chaseArea && Vector2.Distance(Target.position, transform.position) > attackArea) 
        {
            transform.position = Vector2.MoveTowards(transform.position,Target.position,Speed * Time.deltaTime);
        }
    }

}
