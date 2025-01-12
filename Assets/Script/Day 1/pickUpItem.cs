using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class pickUpItem : MonoBehaviour
{
    int apples = 0;
    int pineApples = 0;
    int peanuts = 0;
    int counter = 0;

    public GameObject fruitApple;
    public GameObject fruitPineApple;
    public GameObject fruitPeanut;
    public GameObject Next;

    [SerializeField] private Text scoreText;

   private void Start()
{
    if (scoreText == null)
    {
            scoreText = GetComponent<Text>();
            if (scoreText == null)
        {
            Debug.LogError("Score Text not found in the scene!");
        }
    }
    UpdateScoreText();
}

    public void PickUpItemApples()
    {
        apples++;
        Debug.Log("Apples been add " + apples);
        Instantiate(fruitApple, transform.position, Quaternion.identity);
        counter++;
        Debug.Log("total fruit = " + counter);
        UpdateScoreText();

        if (counter>19){
            counter=19;
        }
        if(apples==20)
        {
            Next.SetActive(true);
        }
    }

    public void PickUpItemPineApples()
    {
        // pineApples++;
        // Debug.Log("pineApples been add " + pineApples);
        // Instantiate(fruitPineApple, transform.position, Quaternion.identity);
        // counter++;
        // Debug.Log("total fruit = " + counter);
        // UpdateScoreText();
    }
    public void PickUpItempeanuts()
    {
        // peanuts++;
        // Debug.Log("peanuts been add " + peanuts);
        // Instantiate(fruitPeanut, transform.position, Quaternion.identity);
        // counter++;
        // Debug.Log("total fruit = " + counter);
        // UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        if (scoreText == null)
        {
            Debug.LogError("Score Text is not assigned!");
            return;
        }

        scoreText.text = counter.ToString();
    }


    public void UnlockNext()
    {
        if (counter > 0)
        {
            
        }

    }
}
