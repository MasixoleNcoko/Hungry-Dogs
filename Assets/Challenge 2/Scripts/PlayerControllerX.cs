using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastPressedTime;
    public float coolDownDuration = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - lastPressedTime >= coolDownDuration)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                Debug.Log("Button Pressed!");
                lastPressedTime = Time.time;
            }
            else
            {
                Debug.Log("Button on cooldown!");
            }
        }

    }

   
}
