using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signScript : MonoBehaviour
{
    public GameObject dialogBox;
    public Text DialogText;
    public string dialog;
    public bool PlayerinRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerinRange)
        {
            if (dialogBox.activeInHierarchy) { dialogBox.SetActive(false); }
            else { dialogBox.SetActive(true); DialogText.text = dialog; }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trent")) { PlayerinRange = true; }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Trent")) {PlayerinRange = false; dialogBox.SetActive(false); }      
    }
}
