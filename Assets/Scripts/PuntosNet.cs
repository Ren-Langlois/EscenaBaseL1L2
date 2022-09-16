using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosNet : MonoBehaviour
{
    public GMcontapuntos GM;
    
    public int puntaje;

    public void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "CarroNet")
        {
            Destroy(gameObject);
            GM.ContarPuntos();
        }
    }
}
