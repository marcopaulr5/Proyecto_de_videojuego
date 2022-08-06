using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRotacion = 250.0f;
    private Animator anim;
    public float x,y;
    private Rigidbody rb;
    //var de salto
    public float fuerzaSalto = 22.0f;
    public float fuerzaExtra = 0.4f;
     // con mas deprisa
    public bool grounded;

   // public float velocidad inicial;
   // public float velocidadAgachado;

  //  public bool estoyAtacando;
  //  public bool avanzandoSolo;
 //   public float impulsoGolpe = 8f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x* Time.deltaTime * velocidadRotacion,0); // Rotacion
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov); // Mover

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);

        if(grounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salto",true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse); 
            }
            anim.SetBool("Grounded",true);

        }
        else 
        {
            Caigo();
        }
    }



    public void Caigo()
    {
        anim.SetBool("Grounded",false);
        anim.SetBool("Salto",false);
    }
}
