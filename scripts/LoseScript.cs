using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject camera;
    public Text DialogText;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Trent").Count() <= 0 && count <= 0) 
        {                    
            Lose();         
            count += 1;                     
        }
    }
    void Lose() 
    {
        camera.SetActive(true);
        DialogText.text = "You Lose"; dialogBox.SetActive(true);
    }
}
