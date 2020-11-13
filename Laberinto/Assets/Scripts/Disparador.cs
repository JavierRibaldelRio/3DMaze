using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    int TotalCubos = 0; //Contador para saber cuantos cubos hay

    public GameObject prefab; // Prefabricado para meter al cubo

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            //Debug.Log("Tecla z presionada");

            GameObject Proyectil = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
           
            Proyectil.name = "Proyectil" + TotalCubos++;


        }
    }

    /*void  Disparar()
    {
        float Aleatorio = Random.Range(-1f, 1f);

        GetComponent<Rigidbody>().AddForce( Vector3.forward * 100f * Time.deltaTime, ForceMode.VelocityChange);
    }*/
}
