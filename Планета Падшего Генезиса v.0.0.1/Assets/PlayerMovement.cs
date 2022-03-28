using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool right = false;
    public bool left = false;
    public bool up = false;
    public bool down = false;
    public bool is_moving = false;
    Animator animator;
    public float speed_x = 0.0f;
    public Vector2 direction;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        bool up = Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.S);
      
        if (right)
        {
            is_moving = true;
            direction.x = 15.0f;

        }
        if (left)
        {
            is_moving = true;
            direction.x = -15.0f;
        }
        if (up)
        {
            is_moving = true;
            direction.y = 15.0f;
        }
        if (down)
        {
            is_moving = true;
            direction.y = -15.0f;
        }
        animator.SetBool("is_moving", is_moving);
        rb.velocity = new Vector2(direction.x, direction.y);
        direction.x = 0;
        direction.y = 0;
        is_moving = false;
    }
}
