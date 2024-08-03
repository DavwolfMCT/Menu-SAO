using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaciaWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
     
            this.gameObject.SetActive(false);
            Debug.Log("TRIIIIGGGEEEERRR");
     
    }
}
