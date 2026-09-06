using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30.0f;
    public float lowerBound = 10.0f;
    public float leftBound = 30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object.
        if (transform.position.z > topBound)
        {
            if (gameObject.CompareTag("Food"))
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
            
        }
        else if (transform.position.z < lowerBound)
        {
            if (gameObject.CompareTag("Food"))
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else if (transform.position.x > leftBound)
        {
            if (gameObject.CompareTag("Food"))
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else if (transform.position.x < -leftBound)
        {
            if (gameObject.CompareTag("Food"))
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
}
