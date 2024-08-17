using System.Collections;
using System.Collections.Generic;
// using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    public float alpha;
    private UnityEngine.UI.Image imageComponent;
    // Start is called before the first frame update
    void Start()
    {
       imageComponent = GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
  
  public void SetOpacity()
  {
    imageComponent.color = new Color(imageComponent.color.r, imageComponent.color.g, imageComponent.color.b, alpha);
  }
}
