using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAudio : MonoBehaviour
{
    [SerializeField] AudioClip soundtrack01;
    [SerializeField] AudioClip soundtrack02;

    [SerializeField] AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (soundtrack02)
            {
                Audio.clip = soundtrack02;
                Audio.Play();
            }
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(soundtrack01){
            Audio.clip = soundtrack01;
            Audio.Play();
        }
    }
}
