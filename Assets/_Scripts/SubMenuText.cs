using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubMenuText : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI subMenuText;
    void Start()
    {
        subMenuText = this.GetComponent<TextMeshProUGUI>();
    }

    public void SelectedText(bool active)
    {
        if(active)
        {
            subMenuText.color = Color.white;
            subMenuText.alpha = 1;
        }
        else
        {
            Color newColor;
            if (ColorUtility.TryParseHtmlString("#444444", out newColor))
                subMenuText.color = newColor;
            subMenuText.alpha = 0.95f;
        }
        
    }
}
