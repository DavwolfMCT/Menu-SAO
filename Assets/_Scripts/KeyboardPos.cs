using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPos : MonoBehaviour
{
    public Transform handPos;
    public float offsetPosX;
    public float offsetPosY;
    public float offsetPosZ;
    public float offsetRotX;
    public float offsetRotY;
    public float offsetRotZ;

     private Vector3 newPosition = new Vector3(); 
     private Vector3 newRotation = new Vector3();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        newPosition = handPos.transform.localPosition + new Vector3(offsetPosX, offsetPosY, offsetPosZ);
        newRotation = new Vector3(offsetRotX, offsetRotY, offsetRotZ);
        this.transform.position = newPosition;
        this.transform.localEulerAngles = newRotation;
    }
}
