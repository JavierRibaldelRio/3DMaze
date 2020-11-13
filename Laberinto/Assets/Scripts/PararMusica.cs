using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PararMusica : MonoBehaviour
{
    AudioListener AL;

    bool AudioEncendido = true;

    public Image ImagenActivado;

    public Image ImagenDesactivado;

    // Start is called before the first frame update
    void Start()
    {
        AL = GameObject.FindWithTag("MainCamera").GetComponent<AudioListener>();

        ImagenDesactivado.enabled = false; //Musica encendida
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopMusica()
    {
        AudioEncendido = !AudioEncendido;

        AL.enabled = AudioEncendido;

        ImagenActivado.enabled = !ImagenActivado.enabled;

        ImagenDesactivado.enabled = !ImagenDesactivado.enabled;
    }
}
