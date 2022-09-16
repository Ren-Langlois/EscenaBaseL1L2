using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosNet : MonoBehaviour
{
    int puntos;
    public Text txtTiempo;
    float time = 60;

    void Update()
    {
        if (puntos == 10)
        {
            time = 60;
            txtTiempo.text = "Felicitaciones, ganaste";
        }
    }

    public void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "CarroNet")
        {
            Destroy(gameObject);
            puntos += 1;
        }
    }

    public void timeResp()
    {
        txtTiempo.text = Mathf.Floor(time + 1).ToString();
        time -= Time.deltaTime;

        if (time < 0 && puntos < 10)
        {
            txtTiempo.text = "Perditse, se te acabo el tiempo";
        }

    }
}
