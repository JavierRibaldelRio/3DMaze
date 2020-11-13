using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    //Varaibles

    [Tooltip("Tiempo inicial")]

    public int TiempoInicial; //Tiempo inicial

    [Tooltip("Escala del tiempo del reloj")]

    [Range(-10.0f, 10.0f)]          //Rango para decidir hasta cundo puede aumentar el valor del tiempo

    public float EscalaTiempo = 1f; //Velocidad a la que va el tiempo

    float TiempoMostrarSegundos = 0f;

    float Escalatiempopausar;

    float EscalaTiempoInicial; //Para el principio

    public  bool Pausado = false; //Para saber si esta pausado

    //Este bool se edita en otro escipt /Users/javier/Desktop/Programación/Grafica/Laberinto/Assets/Scripts/Pause.cs

    string Escena = "Perder";

    GestorEscenas GE;

    public int TiempoFin;

    int SegundosEspera = 1;




    // Start is called before the first frame update
    void Start()
    {
         GE = GameObject.Find("GestorEscenas").GetComponent<GestorEscenas>();


         EscalaTiempoInicial = EscalaTiempo;
            

         TiempoMostrarSegundos = TiempoInicial;

            
         ActualizarReloj(TiempoInicial);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pausado == false)
		{

            if(TiempoMostrarSegundos == TiempoFin )
			{
                //Cambio de escena

                GE.CargaScene(Escena);
			}

            

            PasarTiempo();

            ActualizarReloj(TiempoMostrarSegundos);

                 


        }
        

    }

    public void ActualizarReloj(float TiempoSegundos)
    {
        //


        int Segundos = 0; //Segundoos

        int Minutos = 0; //Minutos

        

        string TextoReloj;

        //Comprobación para saber si nos han dado un valor negativo

        if (TiempoSegundos < 0)
        {
            TiempoSegundos = 0;
        }

        //Calcular en segundos

        Minutos = (int)TiempoSegundos / 60; //Transformamos la variable en int y dividimos

        Segundos = (int)TiempoSegundos % 60; //Transformamos el float en un int y cogemos el resto de la vivisión

        TextoReloj = Minutos.ToString("0000") + ":" + Segundos.ToString("00"); //Concatenar el tiempo

        GetComponent<Text>().text = TextoReloj; //Darle el valor al texto*/
    }

    public void PasarTiempo()
	{
        TiempoMostrarSegundos++;

        

    }

    
    /*[SerializeField]
    private int minutes;

    [SerializeField]
    private int seconds;

    private int m,s;

    [SerializeField]
    private Text timertext;

    void Start()
	{
        startTimer();
	}

    public void startTimer()
	{
        m = minutes;

        s = seconds;

        writetimer(m, s);

        
    }

    void update()
	{
        updatetimer();
	}

    public void stopTimer()
	{

	}

    public void  updatetimer()
	{
        s--;

        if (s < 0)
		{
            if (m == 0)
			{
                //Fin del juego
			}

            else
			{
                m--;

                s = 59;
			}

            writetimer(m, s);

            

        }
	}

    public  void writetimer(int m, int s)
	{
        if (s < 10)
        {
            timertext.text = m.ToString() + ":0" + s.ToString();
        }

		else
        {
            timertext.text = m.ToString() + ":" + s.ToString();
        }
	}

    public int Tiempo = 500;

    [SerializeField]
    private Text timertext;

    void start()
	{
        

        PasarContador();
    }

    void update()
    {
        Tiempo--;

        if (Tiempo == 0)
		{
            //Cambio de escena
		}

        PasarContador();
    }

    public void PasarContador()
	{
        timertext.text = Tiempo.ToString();
	}
    */
}