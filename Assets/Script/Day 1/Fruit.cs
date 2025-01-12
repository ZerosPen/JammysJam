using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitHalfPrefab; // Assign a prefab for the fruit halves

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Detect "knife" or swipe trigger
        if (collision.CompareTag("Knife"))
        {
            CutFruit();
            Debug.Log("Fruit been cut");
        }
    }

    void CutFruit()
    {
        // Instantiate two halves of the fruit
        GameObject half1 = Instantiate(fruitHalfPrefab, transform.position, Quaternion.Euler(0, 0, 15));
        GameObject half2 = Instantiate(fruitHalfPrefab, transform.position, Quaternion.Euler(0, 0, -15));

        // Destroy the original fruit
        Destroy(gameObject);
    }
}