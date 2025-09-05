using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public float zRange = 20.0f;

    public Image[] Hearts;
    private int lives = 3;

    public GameObject projectilePrefab;

    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Instantiate hearts
        Hearts[0].enabled = true;
        Hearts[1].enabled = true;
        Hearts[2].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Left Boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right Boundary
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Top Boundary
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        // Bottom Boundary
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        // Player Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *  verticalInput * Time.deltaTime * speed);
        // Fires out projectile when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            Debug.Log("Player Hit");
            takeDamage();
        }
    }

    void takeDamage()
    {
        // Decrease Lives
        lives--;

        // Disable the heart image that corresponds to the lost life
        if (lives >= 0)
        {
            Hearts[lives].enabled = false;
        }

        // Checks if lives are gone
        if (lives <= 0)
        {
            Debug.Log("Game Over Loser!");
            gameManager.ShowGameOver(); // Reference GameManager
        }
    }

    
}
