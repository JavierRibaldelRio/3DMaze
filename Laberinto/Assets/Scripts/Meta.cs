using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{


    public string Escena;      

    public GameObject p_Meta;

    void awake ()
	{
        //p_Meta = GameObject.Find("Meta");
	}



    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)  
	{
        if (col.gameObject.name == p_Meta.name)
		{
            SceneManager.LoadScene(Escena);
        }

	}
}
