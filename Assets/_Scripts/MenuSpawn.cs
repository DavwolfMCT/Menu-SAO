using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawn : MonoBehaviour
{
    public GameObject SpawnObject;
    public GameObject OvrHMD;
    public float offsetX=0;
    public float offsetY=0;
    public float offsetZ = 0.5f;
    public int rotOffsetX = 0;
    public int rotOffsetY = 0;
    public int rotOffsetZ = 0;

    private Vector3 headPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnInFront()
    {
        Vector3 referencePosition = OvrHMD.transform.position;

        //POSITION
        Vector3 forward = OvrHMD.transform.forward * offsetZ;
        Vector3 right = OvrHMD.transform.right * offsetX;
        Vector3 up = OvrHMD.transform.up * offsetY;

        Vector3 newPosition = referencePosition + forward + right + up;

        //ROTATION
        Quaternion referenceRotation = Quaternion.Euler(rotOffsetX,OvrHMD.transform.eulerAngles.y+rotOffsetY,rotOffsetZ);

        // Instanciar el objeto en la posición calculada
        GameObject newObject = Instantiate(SpawnObject, newPosition, referenceRotation);

        // El objeto no será hijo del objeto de referencia, sino que estará en la raíz de la jerarquía
        //newObject.transform.SetParent(null);
    }

    public void SpawnMap(bool activate)
    {
        bool isMap;
        if(GameObject.FindWithTag("Map"))
            isMap = true;
        else
            isMap = false;

        if(activate && !isMap)
            SpawnInFront();
        else if(!activate && isMap)
            Destroy(GameObject.FindWithTag("Map"));

    }

}
