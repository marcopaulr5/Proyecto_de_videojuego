using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coinCount = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Coin.coinCount = Coin.coinCount +1;
        Debug.Log("Empieza el juego "+ Coin.coinCount + " monedas");
    }

    private void OnTriggerEnter(Collider otherCollider)// condicional para que sea recogida solo por el personaje
    
    {
        if(otherCollider.CompareTag("Player")== true)
        {

        }
        Coin.coinCount--;
        Debug.Log("recogida de moneda " + Coin.coinCount + " monedas restantes");

        if(Coin.coinCount ==0)
        {
            Debug.Log("Se acabaron las monedas ");
        }

        Destroy(gameObject); // la moneda desaperece
     }
    // Update is called once per frame
 }
