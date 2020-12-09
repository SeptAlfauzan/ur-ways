using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    Vector2 input;
    Vector2 speed = new Vector2(5, 5);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");         
        input.y = Input.GetAxis("Vertical");         
    }

    private void FixedUpdate() {
        Vector2 movement = new Vector2(speed.x * input.x, speed.y * input.y);
        movement *= Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + movement);
    }
}
