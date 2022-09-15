using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosNet : MonoBehaviour
{
    int puntos;
    public void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Carro")
            Destroy(gameObject);
        puntos += 1;

    }
}
