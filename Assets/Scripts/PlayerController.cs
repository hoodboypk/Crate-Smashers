using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    private float movementX;
    public Rigidbody2D rb;
    private SpriteRenderer sr;
    // Start is called before the first frame update

    private void Awake()
    {

        sr = GetComponent<SpriteRenderer>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerFlip();
        PlayerJump();
    }

    void PlayerMovement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + new Vector3(movementX, 0, 0)*moveSpeed*Time.deltaTime;

    }

    void PlayerFlip()
    {
        if (movementX > 0)
        {
            sr.flipX = false;
        }

        else if (movementX < 0)
        {
            sr.flipX = true;
        }
    }

    void PlayerJump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
}
