using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicaProyectil : MonoBehaviour
{
    public float Fuerza;

    Rigidbody p_Rigidbody;

    Move p_Move;

    // Start is called before the first frame update
    void Start()
    {

        //Coger el script de movimiento

        p_Move = GameObject.Find("Personaje").GetComponent<Move>();

        //Cojer el componente RigidBody

        p_Rigidbody = GetComponent<Rigidbody>();

        //Añadir una fuerza al objeto

        p_Rigidbody.AddForce(Vector3.forward * Fuerza /*Fuerza*/ * Time.deltaTime, ForceMode.Impulse);
    }











    /*// Update is called once per frame
    void FixedUpdate()
    {
        p_Move.Rotation();

        Movement();
    }

    public float deltaMovement = 10f; 

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


    }*/

}
