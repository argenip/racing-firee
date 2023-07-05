using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitsueloF : MonoBehaviour
{


    public static exitsueloF gomasF;
    public float saltar1;
    public bool GomaF;
    // Start is called before the first frame update
    private void Awake()
    {

        if (exitsueloF.gomasF == null)
        {
            exitsueloF.gomasF = this;
            // DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            GomaF = false;
            Debug.Log(GomaF);
        }
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            GomaF = true;
            Debug.Log(GomaF);
        }

    }

    public void saltar()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * saltar1, ForceMode2D.Impulse);
    }
}
