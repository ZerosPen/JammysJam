using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class condition : MonoBehaviour
{
    public Countscript countscript;
    // Start is called before the first frame update
    void Awake()
    {
        countscript = GameObject.Find("counter").GetComponent<Countscript>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
