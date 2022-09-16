using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMcontapuntos : MonoBehaviour
{
    public int puntos = 0;
    public Text txtPuntos;
    string puntoString;

  
    // Update is called once per frame
    void Update()
    {
        if (puntos == 10)
        {
            GetComponent<timer>().txtTiempo.text = "Felicitaciones, ganaste";
        }
        if (GetComponent<PuntosNet>().puntaje == 1)
        {
            ContarPuntos();
        }
    }

    public void ContarPuntos()
    {
        puntos += 1;

        puntoString = puntos.ToString();
        txtPuntos.text = "Puntos: " + puntoString;
        GetComponent<PuntosNet>().puntaje = 0;
    }

    
}
