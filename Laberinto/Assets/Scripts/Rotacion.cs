using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{

    public float deltaRotation2 = 2.5f; //Rotación

    public float deltaRotation = 5f; //Rotación

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Rotation();

        if (Input.GetKey(KeyCode.W))

            transform.Rotate(new Vector3(-deltaRotation2, 0f, 0f)); //Arriba

        //Abaj

        else if (Input.GetKey(KeyCode.S))

            transform.Rotate(new Vector3(deltaRotation2, 0f, 0f));

    }

    /*void Rotation()
    {
        //Izquierda

        if (Input.GetKey(KeyCode.A))

            transform.Rotate(new Vector3(0f, -deltaRotation, 0f));

        //Derecha

        else if (Input.GetKey(KeyCode.D))

            transform.Rotate(new Vector3(0f, deltaRotation, 0f));
    }*/
}

