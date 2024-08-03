using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorOn : MonoBehaviour
{
    public GameObject pantalla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(!pantalla.activeSelf )
                pantalla.SetActive(true);
            else
            {
                pantalla.SetActive(false);
            }
        }
    }
}
