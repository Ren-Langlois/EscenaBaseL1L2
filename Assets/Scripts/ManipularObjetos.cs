using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField] GameObject[] Net;
    
    // Start is called before the first frame update
    void Start()
    {
        Net = GameObject.FindGameObjectsWithTag("Net");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //DesactivarElementosDelArray();
            AgregarRBAElementosDelArray();
            AgregarColliderAElementosDelArray();
        }
    }

    void DesactivarElementosDelArray()
    {
        for (int i = 0; i < Net.Length; i++)
        {
            Net[i].SetActive(false);
        }
    }

    void AgregarRBAElementosDelArray()
    {
        for (int i = 0; i < Net.Length; i++)
        {        
            Net[i].AddComponent<Rigidbody>();
        }        
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < Net.Length; i++)
        {
            Net[i].AddComponent<BoxCollider>();
        }
    }


}
