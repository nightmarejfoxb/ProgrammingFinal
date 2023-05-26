using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    
    private float hinput;
    private Vector2 movement;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {

        /*
         * FINAL EXAM #1
         * Write a script that will allow movement.
         * The Vertical Axis should make the player move forwards and backwards
         * The Horizontal Axis should make the player rotate on the Vector3.back axis
         */

        movement.y = Input.GetAxis("Vertical");
        hinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * movement);
        transform.Rotate(Vector3.back * turnSpeed * Time.deltaTime * hinput);


    }

}
