using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPrefaps : MonoBehaviour
{
    public Rigidbody objetoPrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){

            Instantiate(objetoPrefab,new Vector3(Random.Range(-10,10),1,
            Random.Range(-10,10)), Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Rigidbody temporal;
                // Creamos el objeto y lo guardamos en temporal
               temporal = Instantiate(objetoPrefab, new Vector3(Random.
               Range(-10,10), 1, Random.Range(-10,10)), Quaternion.identity);

               // Usamos temporal para modifi car las propiedades del objeto
               temporal.velocity = transform.TransformDirection (Vector3. forward * 10);
        }
    }
}
