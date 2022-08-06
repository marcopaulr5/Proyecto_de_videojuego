using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart(){
        SceneManager.LoadScene("SampleScene");
    }

    public void BotonTerreno2(){
        SceneManager.LoadScene("scene3");
    }

    public void BotonQuit(){
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }
}
