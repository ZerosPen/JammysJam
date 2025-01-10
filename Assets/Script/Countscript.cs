using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countscript : MonoBehaviour
{
    private Text score;
    private int counter;
    public GameObject fruit;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = counter.ToString();
    }
    public void AddScore()
    {
        Instantiate(fruit,transform.position,Quaternion.identity);
        counter += 1;
        
    }
}
