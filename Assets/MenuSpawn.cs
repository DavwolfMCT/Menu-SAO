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

    private Vector3 headPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnInFront()
    {
        Vector3 referencePosition = OvrHMD.transform.position;

        // Calcular la nueva posición usando la dirección hacia adelante del objeto de referencia
        Vector3 forward = OvrHMD.transform.forward * offsetZ;
        Vector3 right = OvrHMD.transform.right * offsetX;
        Vector3 up = OvrHMD.transform.up * offsetY;

        // Sumar los offsets a la posición de referencia
        Vector3 newPosition = referencePosition + forward + right + up;

        // Instanciar el objeto en la posición calculada
        GameObject newObject = Instantiate(SpawnObject, newPosition, Quaternion.identity);

        // El objeto no será hijo del objeto de referencia, sino que estará en la raíz de la jerarquía
        newObject.transform.SetParent(null);
    }

}
