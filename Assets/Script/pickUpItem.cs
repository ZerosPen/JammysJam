using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class pickUpItem : MonoBehaviour
{
    int item;
    public void pickUpItems()
    {
        item++;
        Debug.Log("item apple " + item );
    }
}
