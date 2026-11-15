using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;

    public Sprite princeFront;
    public Sprite princeBack;
    public Sprite princeRight;
    public Sprite princeLeft;

    public GameObject weapons;

    Quaternion rotato;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // all movement will have their individual sprites!

        // Horizontal Movement 
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed; // left + left-facing sprite
            
            //player character
            spriteRenderer.sprite = princeLeft;

            //weapon
            rotato = Quaternion.Euler(0, 0, 0);

            weapons.transform.rotation = rotato;
            weapons.transform.localScale = new Vector3(-1, 1, 1);
            weapons.transform.localPosition = new Vector3(1.55999994f, -0.0199999996f, 0f);
            
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed; // right + right-facing sprite

            //player character
            spriteRenderer.sprite = princeRight;

            //weapon
            rotato = Quaternion.Euler(0, 0, 0);

            weapons.transform.rotation = rotato;
            weapons.transform.localScale = new Vector3(1, 1, 1);
            weapons.transform.localPosition = new Vector3(-0.75f, 0.00999999978f, 0f);

        }
        else
        {
            speedX = 0; 
        }

        // Vertical Movement
            if (Keyboard.current.wKey.isPressed)
            {
                speedY = moveSpeed; // up + back sprite

                //player character 
                spriteRenderer.sprite = princeBack;

                //weapon
                rotato = Quaternion.Euler(0f, 0f, 90f); //because transforming the rotation doesn't work the same as scale/position

                weapons.transform.localScale = new Vector3(1, 1, 1);
                weapons.transform.rotation = rotato;
                weapons.transform.localPosition = new Vector3(-2.9000001f, 3.45000005f, 0f);


            }
            else if (Keyboard.current.sKey.isPressed)
            {
                speedY = -moveSpeed; // down + front sprite

                //player character
                spriteRenderer.sprite = princeFront;

                //weapon
                rotato = Quaternion.Euler(0f, 0f, -90f);

                weapons.transform.localScale = new Vector3(1, 1, 1);
                weapons.transform.rotation = rotato;
                weapons.transform.localPosition = new Vector3(-0.649999976f, 0.5f, 0f);

            }
            else
            {
                speedY = 0;
            }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
