using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHandDo : MonoBehaviour
{
    private GameObject leftHandController;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        leftHandController = GameObject.Find("LeftHand Controller"); //Guarda el objeto del control izquierdo XR
    }

    // Update is called once per frame
    void Update()
    {
        if (leftHandController.transform.localRotation.eulerAngles.z > 30 && leftHandController.transform.localRotation.eulerAngles.z< 180) //Registra la posicion angular de la muñeca
        {
           menu.SetActive(true); //activa el menu si esta en la posicion correcta
        }
        else
        {
            menu.SetActive(false); //sino lo desactiva
        }
    }
}
