using UnityEngine;
using UnityEngine.InputSystem;

public class RobertMove : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jump = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f; 
        body.gravityScale = 0f; //for bird eye view
        

    //Left right movement inputs
    if (Keyboard.current.aKey.isPressed)
        horizontalInput = -1f;
    else if (Keyboard.current.dKey.isPressed)
        horizontalInput = 1f;

    if (Keyboard.current.leftArrowKey.isPressed)
        horizontalInput = -1f;
    else if (Keyboard.current.rightArrowKey.isPressed)
        horizontalInput = 1f;

    //Up down movement inputs
    if (Keyboard.current.wKey.isPressed)
        verticalInput = 1f;
    else if (Keyboard.current.sKey.isPressed)
        verticalInput = -1f;
  
    if (Keyboard.current.upArrowKey.isPressed)
        verticalInput = 1f;
    else if (Keyboard.current.downArrowKey.isPressed)
        verticalInput = -1f;

    

    //Flip the character to face direction of movement
    if (horizontalInput > 0.01f)
        transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
    else if (horizontalInput < -0.01f)
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

    //Set velocity based on input (Take off for birds eye view)
    //body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

    //Jump input (Take off when doing birds eye view)
    //if (Keyboard.current.spaceKey.wasPressedThisFrame)
      //  body.linearVelocity = new Vector2(body.linearVelocity.x, jump);

        //for bird eye view
        body.linearVelocity = new Vector2(horizontalInput * speed, verticalInput * speed);
        
    }
}