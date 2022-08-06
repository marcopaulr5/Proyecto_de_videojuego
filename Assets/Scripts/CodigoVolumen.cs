using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CodigoVolumen : MonoBehaviour
{
    // Start is called before the first frame update7
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;
    void Start()
    {
        slider.value= PlayerPrefs.GetFloat("volumen",0.5f);
        AudioListener.volume= slider.value;
        RevisarSiEstoyMute();
    }

    public void ChangeSlider(float valor){
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumen", sliderValue);
        AudioListener.volume= slider.value;
        RevisarSiEstoyMute();
    }
    public void RevisarSiEstoyMute(){
        if(sliderValue==0){
            imagenMute.enabled = true;
        }   
        else{
            imagenMute.enabled = false;
        }
}
}