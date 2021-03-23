using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeartManager : MonoBehaviour
{
    public Image[] Hearts;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    public FloatValue HeartContainers;
    public FloatValue PlayerHealth;
    void Start()
    {
        InitialHearts();
    }

    public void InitialHearts() 
    {
        for (int i = 0; i < HeartContainers.startingValue; i++) 
        {
            Hearts[i].gameObject.SetActive(true);
            Hearts[i].sprite = FullHeart;
        }
    }
    public void UpdateHearts()
    {
        for (int i = 0; i < HeartContainers.startingValue; i++) 
        {
            if (i <= PlayerHealth.CurrentValue-1) 
            {
                Hearts[i].sprite = FullHeart;
            }
            else if (i >= PlayerHealth.CurrentValue - 1)
            {
                Hearts[i].sprite = EmptyHeart;
            }
        }
    }
}
