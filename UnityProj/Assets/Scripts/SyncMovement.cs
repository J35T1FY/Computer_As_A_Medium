using UnityEngine;
using UnityEngine.InputSystem;

public class SyncMovement : MonoBehaviour
{
    //public Rigidbody2D rb; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        syncMovement();
    }

    void syncMovement()
    {
        //this will sync objects with one sprite to the movement of the player)
        
        if (Keyboard.current.aKey.isPressed)
        {
            transform.localScale = new Vector3(-1.33460164f, 4.60437489f, 3.33650327f); //flips
        }
        else if (Keyboard.current.dKey.isPressed) 
        {
            transform.localScale = new Vector3(1.33460164f, 4.60437489f, 3.33650327f); //resets
        }
        else 
        {
            //NOTHING CHANGES!!!
        }
    }
}
