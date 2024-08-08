using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleClickHandler : MonoBehaviour, IPointerDownHandler
{
        public AudioClip clickAudio;
        private AudioSource _audioSource;


    public void OnPointerDown(PointerEventData eventData)
    {
        // Aquí puedes manejar la lógica que deseas ejecutar
        Debug.Log("Toggle Clicked");
        _audioSource = GetComponent<AudioSource>();
        _audioSource.PlayOneShot(clickAudio);





        // Opcional: Cambiar el estado del Toggle si es necesario
        // Toggle toggle = GetComponent<Toggle>();
        // if (toggle != null)
        // {
        //     toggle.isOn = !toggle.isOn;
        // }
    }
}
