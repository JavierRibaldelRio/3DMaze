using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Incluimos la libreria

public class GestorEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CargaScene(string p_NombreScene)
	{
        SceneManager.LoadScene(p_NombreScene);
	} 
}
