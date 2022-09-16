using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject tiempo;
    public Text txtTiempo;
    
    float time = 60;
    
    public bool activaTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            activaTime = true;
        }

        if (activaTime == true)
        {
            timeResp();
        }
        

        //if (GetComponent<DialogeManager>().ayuda == )
        //{
        //    timeResp();
        //    tiempo.SetActive(true);
        //}
    }

    

    public void timeResp()
    {
        activaTime = true;
        tiempo.SetActive(true);
        txtTiempo.text = Mathf.Floor(time).ToString();
        time -= Time.deltaTime;

        if (time < 0)
        {
            txtTiempo.text = "Perdiste, se te acabo el tiempo";
            time = 60;
        }

    }
}
