using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GomaB : MonoBehaviour
{


    public static GomaB lasgomas;



    private Renderer rend;
    [SerializeField]
    private Color colorToTurnTo = Color.white;


    [SerializeField]
    private Color colorToTurnToActivar = Color.white;



    private void Awake()
    {
        if (GomaB.lasgomas == null)
        {
            GomaB.lasgomas = this;

        }

    }

    void Start()
    {
        rend = GetComponent<Renderer>();

    }


    // Update is called once per frame



    public void destivarGoma()
    {
        rend.material.color = colorToTurnTo;
    }


    public void AtivarGoma()
    {
        rend.material.color = colorToTurnToActivar;
    }

    public void desativarcollider()
    {
        rend.gameObject.GetComponent<CircleCollider2D>().enabled = false;


    }

    public void ativarcollider()
    {
        rend.gameObject.GetComponent<CircleCollider2D>().enabled = true;


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "suelo")
        {
            Debug.Log("todando fondo");
        }
    }
}
