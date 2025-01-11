using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingMiniGame : MonoBehaviour
{
    private bool play = false;
    private int direction;
    private bool inZone = false;
    private int score = 0;

    [SerializeField] private Transform coin;
    [SerializeField] private GameObject coinGlow;
    [SerializeField] private Transform line;
    [SerializeField] private float speed = 5f; // Default speed
    [SerializeField] private float maxSpd = 20f;

    // Start is called before the first frame update
    void Start()
    {
        if (line == null || coin == null || coinGlow == null)
        {
            Debug.LogError("One or more required references are not assigned!");
            return;
        }

        direction = Random.Range(0, 2) == 0 ? -1 : 1;
        Debug.Log("Game Initialized. Direction: " + direction);
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            // Continuously rotate the line
            line.Rotate(Vector3.forward * speed * direction * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinGlow.SetActive(true);
            inZone = true;
            Debug.Log("Coin Entered Zone");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinGlow.SetActive(false);
            inZone = false;
            Debug.Log("Coin Left Zone");
        }
    }

    public void Click()
    {
        // If the coin is in the zone, process the click
        if (inZone)
        {
            direction *= -1; // Reverse direction
            speed = Mathf.Min(speed + 3, maxSpd); // Increase speed but cap at maxSpd
            score++;
            Debug.Log("Successful Click! Score: " + score + ", Speed: " + speed);

            NewCoin();
        }
    }

    public void NewCoin()
    {
        // Rotate the coin to a new random position
        float temp = Random.Range(30, 330);
        coin.Rotate(Vector3.forward * temp);

        if (coin.childCount > 1)
        {
            coin.GetChild(1).Rotate(Vector3.forward * temp * -1);
        }
        else
        {
            Debug.LogWarning("Coin does not have enough children to rotate.");
        }
    }

    public void Play()
    {
        play = true;
        Debug.Log("Game Started");
    }
}
