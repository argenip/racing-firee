using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{

    //animacion
    public Animator anim;
    public static animacion animacionex;
    public Rigidbody2D carRigidbody;

    public Rigidbody2D ftires;
    public Rigidbody2D btires;



    private void Awake()
    {
        if (animacion.animacionex == null)
        {
            animacion.animacionex = this;

        }

    }



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      //  playerController.botones.movimientoAnimaciones();
      //  anim.SetFloat("run", Mathf.Abs(transform.position.x));

        if (Input.GetKeyDown(KeyCode.K))
        {
            prueba0();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            prueba1();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            prueba2();
        }
    }

    void prueba0()
    {
        anim.SetTrigger("pop");
    }

    void prueba1()
    {
        anim.SetTrigger("pip");
    }

    void prueba2()
    {
        anim.SetTrigger("pup");
    }

    public void estado()
    {
       // transform.position = new Vector3(transform.position.x, transform.position.y, 9.278001f);
    }

    public void estbilizar()
    {
        btires.constraints = RigidbodyConstraints2D.FreezeRotation;
        ftires.constraints = RigidbodyConstraints2D.FreezeRotation;
        carRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
       // Debug.Log("freeeeeeee");
    }


    public void normalizar()
    {
        btires.constraints = RigidbodyConstraints2D.None;
        ftires.constraints = RigidbodyConstraints2D.None;
        carRigidbody.constraints = RigidbodyConstraints2D.None;
      //  Debug.Log("noo     freeeeeeee");
    }
}
