using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoChoque : MonoBehaviour
{

    AudioSource AS; //Reproductor de audio

    public GameObject Personaje; //Variable para contener el personaje

    // Start is called before the first frame update

  

    void Start()
    {
        //Coger el componente AudioSource

        AS = GetComponent<AudioSource>();
    }

    
    void OnCollisionEnter (Collision col )
    {
        if (col.gameObject.name == Personaje.name)
		{
            AS.Play();
		}
    }

   
}
