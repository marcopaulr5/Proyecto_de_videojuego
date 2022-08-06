using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detecta_Floor : MonoBehaviour
{
    public Controller controllerSal;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        controllerSal.grounded = true;
    }

    private void OnTriggerExit(Collider other){
        controllerSal.grounded = false;
    }


 }
