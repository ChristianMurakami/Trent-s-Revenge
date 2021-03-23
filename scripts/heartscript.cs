using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartscript : MonoBehaviour
{
    public GameObject heart;
    bool PlayerinRange ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerinRange) { heart.SetActive(false); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trent")) { PlayerinRange = true; }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Trent")) { PlayerinRange = false;}
    }
}
