using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    bool ActivadoCanvasPause;           //Si no hay valor asignado en un bool es falso

    bool ActivadoCanvasPrincipal = true ;

    Canvas canvas;           //Pause 

    Canvas CanvasPrincipal;  //Principalll

    Cronometro cronometro;  //Cronometro

    // Start is called before the first frame update
    void Start()
    {
        //Cronometro

        cronometro = GameObject.Find("Temporizador").GetComponent<Cronometro>();

        //CanvasPause

        canvas = GetComponent<Canvas>();

        canvas.enabled = false; //Para desactivar el canvas

        //Canvas del Juego

        CanvasPrincipal = GameObject.Find("CanvasPrincipal").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
       

		
    }

    //Creamos un void para el pausa, se acionara

    public void Pausa()
	{
        //Con!(Nombre de Variable)invertimos la variable

        ActivadoCanvasPause = !ActivadoCanvasPause;  

        canvas.enabled = ActivadoCanvasPause;

        ActivadoCanvasPrincipal = !ActivadoCanvasPrincipal;

        CanvasPrincipal.enabled = ActivadoCanvasPrincipal;

        //Para parar el juego

        Time.timeScale = (ActivadoCanvasPause) ? 0 : 1f;

        //Pausar el cronometro

        cronometro.Pausado = !cronometro.Pausado; 


    }
}
