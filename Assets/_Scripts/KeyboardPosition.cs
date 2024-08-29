using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyboardPosition : MonoBehaviour
{
    public Transform handPos;
    public float offsetPosX;
    public float offsetPosY;
    public float offsetPosZ;
    public float offsetRotX;
    public float offsetRotY;
    public float offsetRotZ;
    public float worldOffsetY;

     private Vector3 newPosition = new Vector3(); 
     private Vector3 newRotation = new Vector3();
     private Vector3 newPosition2 = new Vector3(); 
     private Vector3 newRotation2 = new Vector3();
     private GameObject WorldMenu;

   
   //METHODS
    public void GetMenu()
    {
        WorldMenu = GameObject.FindGameObjectWithTag("WorldMenu");
    }

     // Update is called once per frame
    void Update()
    {
        if(WorldMenu != null)
        {
            newPosition = WorldMenu.transform.position + new Vector3(0, worldOffsetY, -0.02f);;
            newRotation =  WorldMenu.transform.localEulerAngles + new Vector3(0, 180, 0);;
            this.transform.position = newPosition;
            this.transform.localEulerAngles = newRotation;
            this.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
            this.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
        }
        else
        {


            newPosition2 = handPos.transform.position + new Vector3(offsetPosX, offsetPosY, offsetPosZ);
            newRotation2 = new Vector3(offsetRotX, offsetRotY+ handPos.transform.localEulerAngles.y, offsetRotZ);
            this.transform.position = newPosition2;
            this.transform.localEulerAngles = newRotation2;
            this.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
        }
    }




    // public void UpdatePositionKeyboard(Transform refPos, float offPosX, float offPosY, float offPosZ, float offRotX, float offRotY, float offRotZ )
    // {
    //     newPosition = refPos.transform.localPosition + new Vector3(offPosX, offPosY, offPosZ);
    //     newRotation = new Vector3(offRotX, offRotY, offRotZ);
    //     this.transform.position = newPosition;
    //     this.transform.localEulerAngles = newRotation;   
    // }
}
