using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //Variables de movimiento

    public float deltaRotation = 5f; //Rotación

    public float deltaMovement = 10f; //Movimiento

    public float deltaSalto = 5f;  //Salto

    public float TiempoEspera = 3f; //Tiempo de espera

    //GET COMPONENT

    

    //CambioPause CP;



    //void Awake()
    //{

    //     CP = GameObject.Find("GestorEscenas").GetComponent<CambioPause>();

    //}

    //   // Start is called before the first frame update
    //   void Start()
    //   {
    //      transform.Translate(CP.Cordenadas);
    //   }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rotation();

        Movement();

        Salto();

    }

    // Función de rotación
    public void Rotation()
    {
        //Izquierda

        if (Input.GetKey(KeyCode.A))

            transform.Rotate(new Vector3(0f, -deltaRotation, 0f));

        //Derecha

        else if (Input.GetKey(KeyCode.D))

            transform.Rotate(new Vector3(0f, deltaRotation, 0f));
    }

    //Función de movimiento
     void Movement()
    {
        //Delante

        //Buen funcinamiento
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
        }

        //Atras
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        }

        //Derecha

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
        }

        //Izquierda

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
        }

        //Prueba

        /*if (Input.GetKey(KeyCode.UpArrow))
        {

            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.forward * deltaMovement * Time.deltaTime);


        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.left * deltaMovement * Time.deltaTime);


        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {

            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.right * deltaMovement * Time.deltaTime);


        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {

            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.back * deltaMovement * Time.deltaTime);


        }
        */
    }

    void Salto()
    {
        if (Input.GetKeyUp(KeyCode.Space))
		{
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.up * deltaSalto * Time.deltaTime);

            new WaitForSeconds(TiempoEspera);
        }
        

    }


    //para esperar tiempo antes de que pase una acción

  /* IEnumerator Esperar()
    {

        yield return new WaitForSeconds(TiempoEspera);

    }*/
}


