using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roy : MonoBehaviour
{
    

    public float speed;
    public Rigidbody2D backWheel;
    public Rigidbody2D frontWheel;
    public float movement;


    public Rigidbody2D rb;
    // probnado si hacen algo
    // private float movementR = 0f;
    // private float rotation = 0f;
    // probnado si hacen algo
    public float rotationSpeed = 15f;

  


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        movement = -speed * 3f;



    }

    private void FixedUpdate()
    {
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        if (Input.GetKey(KeyCode.W))
        {
            acelerar();
        }
     
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.A))
        {
            exitsueloF.gomasF.GomaF = true;
           rb.constraints = RigidbodyConstraints2D.None;
            rb.AddTorque(2 * rotationSpeed * Time.fixedDeltaTime);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
           // exitsuelo.gomas.gomaB = false;
            exitsueloF.gomasF.GomaF = false;
        }

        if (Input.GetKeyDown(KeyCode.A) && exitsuelo.gomas.gomaB == true)
        {
            if(exitsueloF.gomasF.GomaF == false)
            {
                exitsueloF.gomasF.GomaF = true;
            }

            exitsuelo.gomas.gomaB = true;
            
            rb.constraints = RigidbodyConstraints2D.None;
            exitsueloF.gomasF.saltar();
        }

 ////////////////////////////////////////////////////////////////////////////
            if (Input.GetKey(KeyCode.D))
        {
            exitsuelo.gomas.gomaB = true;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.AddTorque(-2 * rotationSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            exitsuelo.gomas.gomaB = false;
        }

/////////////////////////////////////////////////////////////////////
        if (exitsuelo.gomas.gomaB == false && exitsueloF.gomasF.GomaF == false)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else if(exitsuelo.gomas.gomaB == false && exitsueloF.gomasF.GomaF == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        else if (exitsuelo.gomas.gomaB == true && exitsueloF.gomasF.GomaF == false)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }

    }

    private void acelerar()
    {

        frontWheel.AddTorque(movement * Time.fixedDeltaTime);
        backWheel.AddTorque(movement * Time.fixedDeltaTime);
    }
}
