using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;
    private CoinManager coinManager;


    private void Start()
    {
        coinManager = CoinManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("line")&&!hasTriggered)
        {
            hasTriggered = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("line"))
        {
            hasTriggered = false; // Reset the flag when exiting the trigger
        }
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.CompareTag("line")&&!hasTriggered)
    //     {
    //         hasTriggered = true;
          
    //     }
    //     else if(collision.CompareTag("coin")&&hasTriggered)
    //     {
    //         hasTriggered = false;
          
    //     }
    // }

 

    // Update is called once per frame
    void Update()
    {
        if(hasTriggered && Input.GetMouseButtonDown(0))
        {
            coinManager.ChangeCoins(value);
            Destroy(gameObject);
        }
    }
}
