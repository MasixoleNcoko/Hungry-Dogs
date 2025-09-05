using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // When pizza hits dog
        if(gameObject.CompareTag("Food") && other.CompareTag("Dog"))
        {
            // Look for DogStats component on the dog we hit
            DogStats dogStats = other.GetComponent<DogStats>();

            if(dogStats == null)
            {
                // In case the collider is on a child object, try the parent
                dogStats = other.GetComponentInParent<DogStats>();
            }

            if(dogStats != null && ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(dogStats.points);
            }

            Debug.Log("Dog fed");
            Destroy(gameObject); // Destroy pizza
            Destroy(other.gameObject); // Destroy dog

        }
        // When dog hits player
        else if(gameObject.CompareTag("Dog") && other.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
            Destroy(gameObject); // Destroy dog
        }
    }

}
