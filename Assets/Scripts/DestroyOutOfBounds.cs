using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30.0f;
    private float bottomBounds = -10.0f;
    private float leftBounds = -20.0f;
    private float rightBounds = 20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy everything that goes out of bounds
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x < leftBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBounds)
        {
            Destroy(gameObject);
        }
    }
}
