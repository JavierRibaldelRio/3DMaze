using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    //Variables

    public float RadioVision; //Radio de visión

    public float Velocidad;   //Para guardar a la velocidad a la que se movera el objeto(Mounstruo)

    float VelocidadInicial;   //Para gurdar la velocidad original

    //Variable para guardar a el jugador

    public GameObject Personaje;    //Definido en la interfaz de unity

    //vector para guardar la posición inicial

    Vector3 PosicionInicial;

    //variables cambiar de escena

    public string EscenaCambio;


    bool Facil = false;
    

    // Start is called before the first frame update
    void Start()
    {
        PosicionInicial = transform.position;

        //Le damos el valor de la velocidad a la velocidad original

        VelocidadInicial = Velocidad; 
    }

    // Update is called once per frame
    void Update()
    {

        Velocidad = VelocidadInicial;

        if (Facil == true)
        {
            Velocidad = Velocidad / 2f;
        }

        Vector3 Targeta = PosicionInicial;

        float Distancia = Vector3.Distance(Personaje.transform.position, transform.position);

        if (Distancia < RadioVision)
        {
            Targeta = Personaje.transform.position;

        }

        float VelocidadFijada = Velocidad * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, Targeta, VelocidadFijada);

    }


    void OnCollisionEnter(Collision p_Collision)
    {
        if(p_Collision.gameObject.name == "Personaje")
        {
            SceneManager.LoadScene(EscenaCambio);
        }
    }

    public void CargaScene(string p_NombreScene)
    {
        SceneManager.LoadScene(p_NombreScene);
    }

    public void DificultadFacil()
    {
        Facil = true;
    }

    public void DificultadDificil()
    {
        Facil = false;
    }
}
