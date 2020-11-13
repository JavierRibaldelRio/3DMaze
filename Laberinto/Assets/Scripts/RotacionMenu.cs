using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public float VelocidadRotacion = 15f;

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, VelocidadRotacion, 0f)*Time.deltaTime);
    }
}
