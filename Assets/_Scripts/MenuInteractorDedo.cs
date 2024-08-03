using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuInteractorDedo : MonoBehaviour
{
    public Button boton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>(); //Guarda su componente Button en una variable
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerStay(Collider other) //Mientras el boton este en contacto...
    {
        if (other.gameObject.CompareTag("Dedo")) //... Con el dedo...
        {
            boton.GetComponent<Image>().color = new Color(0.5f,0.5f,0.5f); //Cambia el color del boton
           Debug.Log("BOTON");
        }
        else
        {
            
        }
        
    }

    private void OnTriggerExit(Collider other) //Y deja el color normal cuando salga de contacto
    {
        boton.GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f);
    }


}
