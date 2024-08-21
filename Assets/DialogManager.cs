using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dialog;
    private GameObject newDialog;
    void Start()
    {
        
    }

    public void ShowDialog()
    {
        // Obtener la posición, rotación y parent del objeto original
        Vector3 originalPosition = Dialog.transform.position;
        Quaternion originalRotation = Dialog.transform.rotation;
        Transform originalParent = Dialog.transform.parent;

        // Instanciar el objeto con la misma posición, rotación y parent
        GameObject newDialog = Instantiate(Dialog, originalPosition, originalRotation, originalParent);

        // Opcional: si quieres asegurarte que la escala sea la misma
        newDialog.transform.localScale = Dialog.transform.localScale;
        newDialog.tag = "Dialog";
        newDialog.SetActive(true);
    }

    public void DestroyDialog()
    {
        Transform canvaDialog = transform.GetChild(0);
        
        foreach (Transform child in canvaDialog)
        if (child.CompareTag("Dialog"))
        {
            Debug.Log("Detroying.... " + child.name.ToString());
            Destroy(child.gameObject);
        }
    }
    
}
