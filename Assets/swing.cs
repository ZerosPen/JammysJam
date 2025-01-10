using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{

    bool play;
    int direction;
    [SerializeField] Transform coin;
    [SerializeField] GameObject coinGlow;
    [SerializeField] Transform line;
    [SerializeField] float speed;

    bool inZone;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        int temp = Random.Range(0,2);
        if(temp==0)
        {
            direction = -1;
        }
        else
        {
            direction = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(play)
        {
            line.Rotate(Vector3.forward * speed * direction * Time.deltaTime);
        }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Coin")
        {
            coinGlow.SetActive(true);
            inZone = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        coinGlow.SetActive(false);
        if(inZone)
        {
            InGameUI.instance.GameOver(score);
            play=false;
        }
    }
}

public void(Click)
{
    if(inZone)
    {
        direction *= -1;
        speed += 3;
        score++:
        inZone = false;
        NewCoin();
        InGameUI.instance.UpdateScoreDisplay(score.ToString());
    }
    else
    {
        InGameUI.instance.GameOver(score);
        play = false;
    }
}

public void Click()
{
    if(inZone)
    {
        direction *=-1;
        speed += 3;
        score++;
        inZone = false;
        NewCoin();
        InGameUI.instance.UpdateScoreDisplay(score.ToString);
    }
    else
    {
        inGameUI.instance.GameOver(score);
        play = false;
    }
}

public void NewCoin()
{
    float temp = Random.Range(30,330);

    coin.Rotate(Vector3.forward*temp);
    coin.GetChild(1).Rotate(Vector3.forward*temp*-1);
}

public void Play()
{
    play=true;
}
}