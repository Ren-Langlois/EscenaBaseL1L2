using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    [SerializeField] bool hasTalked;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && hasTalked == false)
        {
            NextFrase();
        }   
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCBehavior>().Data.dialogueFrases;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "Pulsa A para continuar";
            }

            else
            {
                textoDelDialogo.text = "Hola, vas a tener que buscar un obejeto por todo este espacio. ";
            }   
          

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
           //al entrar desactiva la UI de dialogo
            dialogueUI.SetActive(false);
        }
    }

    void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }
        
    }
}
