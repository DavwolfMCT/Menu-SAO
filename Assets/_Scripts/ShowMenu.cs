using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ShowMenu : MonoBehaviour
{
    public GameObject CanvaMenu; //ES EL CANVAS
    
    public AudioClip menuoffAudio;
    public AudioClip menuonAudio;
    public float distance = 0.2f; // 20 cm
    public float duration = 2f; // 2 s
    private AudioSource _audioSource;

    private GameObject[] principalBts;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        principalBts = GetPrincipalButtons();
        SetDefault();
    }


//PUBLIC METHODS

    public void OpenMenuSound()
    {
        _audioSource.PlayOneShot((menuonAudio));
    }

    public void ShowAnimation()
    {
        if(!this.gameObject.CompareTag("HandMenu"))
            StartCoroutine(MoveVerticalCoroutinesSequentially(principalBts));
    }




//PRIVATE METHODS

    private void OnTriggerEnter(Collider other) //Si este objeto (el MENU) entra en contacto...
    {
        if (other.gameObject.CompareTag("Dedo")) //... con el collider del "Dedo"
        {           
            Debug.Log("El CanvaMenu de: " + this.gameObject.name + ", esta: " + CanvaMenu.activeSelf.ToString());
            if (!CanvaMenu.activeSelf) //en caso de que no este activo el CanvasMenu pues lo activa
            {
                CloseExistingMenus();
                OpenHandMenu();
            }    
            else
            {
                CloseHandMenu();
            }
        }
    }

    private void OpenHandMenu()
    {
        CanvaMenu.SetActive(true);
        _audioSource.PlayOneShot(menuonAudio);
        foreach (GameObject btn in principalBts)
        {
            btn.SetActive(true);
        }
    }

    private void CloseHandMenu()
    {
        CanvaMenu.SetActive(false); //de lo contrario que ya esta activo entonces el trigger provoca que lo desactive
        _audioSource.PlayOneShot(menuoffAudio);
    }

    private void CloseExistingMenus()
    {
        Debug.Log("Cerrando Menus por: " + this.gameObject.name);
        Destroy(GameObject.FindWithTag("WorldMenu"));
    }

    private void SetDefault()
    {
        foreach (GameObject btn in principalBts)
        {
            btn.SetActive(false);
        }       
    }

    private GameObject[] GetPrincipalButtons()
    {
        Transform fchild = this.transform.GetChild(0);
        Transform child = fchild.transform.GetChild(0); // Reemplaza index con el índice del hijo
        GameObject[] PrincipalBotPs = new GameObject[child.childCount];

        for (int i = 0; i < child.childCount; i++)
        {
            PrincipalBotPs[i] = child.GetChild(i).gameObject;
        }

        return PrincipalBotPs.Reverse().ToArray();

    }

    IEnumerator MoveVerticalCoroutinesSequentially(GameObject[] principalBts)
    {
        foreach (GameObject btn in principalBts)
        {
            Debug.Log("XXX, ANIMANDO: " + btn.name);
            btn.SetActive(true);
            yield return StartCoroutine(MoveVerticalCoroutine(btn.GetComponent<RectTransform>()));
        }
    }

    IEnumerator MoveVerticalCoroutine(RectTransform rectTransformToMove)
    {
        Vector3 startPosition = rectTransformToMove.position;
        Debug.Log("XXX, Posi: " + startPosition.ToString());
        Vector3 endPosition = startPosition + new Vector3(0, distance, 0);
        Debug.Log("XXX, PosF: " + endPosition.ToString());
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            Debug.Log("XXX, PosActual: " + rectTransformToMove.position.ToString());
            rectTransformToMove.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rectTransformToMove.position = endPosition; // Asegúrate de que el RectTransform llegue exactamente al final
        Debug.Log("XXX, PosUltima: " + rectTransformToMove.position.ToString());
    }
}


