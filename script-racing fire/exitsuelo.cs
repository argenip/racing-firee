using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitsuelo : MonoBehaviour
{

    public static exitsuelo gomas;

    public bool gomaB;
    // Start is called before the first frame update
    private void Awake()
    {

        if (exitsuelo.gomas == null)
        {
            exitsuelo.gomas = this;
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
            gomaB = false;
            Debug.Log(gomaB + " Gomas B");
        }
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "suelo")
        {
            gomaB = true;
            Debug.Log(gomaB + " Gomas B");
        }

    }


}
