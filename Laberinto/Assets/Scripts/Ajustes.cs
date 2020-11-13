using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ajustes : MonoBehaviour
{
    bool ActivadoCanvasPause = true;

    bool ActivadoCanvasAjustes;

    //Para albergar los Canvas 

    public Canvas CanvasPause;

    Canvas CanvasAjustes;

    // Start is called before the first frame update
    void Start()
    {
        //Obtener el canvase

        CanvasAjustes = GetComponent<Canvas>();

        CanvasAjustes.enabled = false;

        //CanvasPause = GameObject.Find("CanvasPause").GetComponent<CanvasPause>();

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirAjustes ()
    {
        ActivadoCanvasAjustes = !ActivadoCanvasAjustes;

        CanvasAjustes.enabled = ActivadoCanvasAjustes;

        ActivadoCanvasPause = !ActivadoCanvasPause;

        CanvasPause.enabled = ActivadoCanvasPause;
    }
}
