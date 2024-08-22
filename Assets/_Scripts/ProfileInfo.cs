using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class ProfileInfo : MonoBehaviour
{
    public string textInfo = "";
    private TextMeshProUGUI textMeshProComponent;
    private GameObject sender;
    // Start is called before the first frame update
    void Start()
    {
         textMeshProComponent = GetComponent<TextMeshProUGUI>();
    }

    public void SetProfileInfo(string textInfo)
    {
        textMeshProComponent.SetText(textInfo);
    }

    
    public void SetSender(GameObject sender)
    {
        this.sender = sender;
    }

    public void SelectItemInfo(string textSelect)
    {
        textMeshProComponent.SetText(textSelect +"<color=blue>" +sender.name.ToString()+"</color>");
    }

}
