using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincipalButtons : MonoBehaviour
{
    public GameObject Button;
    public GameObject Slider;
    public GameObject Slider2;
    
    
    public AudioClip ClickAudio;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    private void OnTriggerEnter(Collider other) //Cuando el BotonPrincipal entre en contacto...
    {
        if (other.gameObject.CompareTag("Dedo"))//.. con el Dedo...
        {
            _audioSource.PlayOneShot(ClickAudio);
            if (!this.gameObject.GetComponent<MeshRenderer>().enabled) //Si el boton no esta encendido
            {
                
                
                
                this.gameObject.GetComponent<MeshRenderer>().enabled = true; //enciende el boton
                if(  this.gameObject.name == "BotP") //EN CASO de que este collider sea el del botonP (El de configuracion)
                {
                    
                    Button.SetActive(true); //Vamos a mostrar el boton y el slider
                    Slider.SetActive(true);
                    Slider2.SetActive(true);
                    
                   
                }


            }
            
            
            
            
            else //Si el boton ya estaba encendido (osea que estaba activo mostrando sus submenus) [En teoria cualquier boton]
            {
                this.gameObject.GetComponent<MeshRenderer>().enabled = false; //Entonces como estaba prendido ahora apagalo
                if(  this.gameObject.name == "BotP") //Si este objeto era el boton de configuracion ahora tenemos que desactivar tambien sus submenus [[[PODRIA SER UN WHILE???]]]
                {
               
                    Button.SetActive(false);
                    Slider.SetActive(false);
                    Slider2.SetActive(false);
                    
                
                }
            }
          
        }
    }
    

//Esto apaga el boton que haya encendido cuando se quita el dedo siempre y cuando no sea el boton de configuracion porque ese si tiene funciones y queremos dejar el boton iluminado
    private void OnTriggerExit(Collider other) 
    {
        if(this.gameObject.name != "BotP")
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

}
