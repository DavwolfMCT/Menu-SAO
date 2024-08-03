using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject hand;
    private Quaternion menuRotation;

    public float xOffset;
    public float yOffset;
    public float zOffset;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OpenMenu()
    {
        if(menu.transform.GetChild(0).gameObject.activeSelf)
            menu.transform.GetChild(0).gameObject.SetActive(false);
        
        menuRotation = Quaternion.Euler(0,hand.transform.eulerAngles.y-180,0) ;

        CloseExistingMenus();
        Vector3 offsetMenuSpawm = hand.transform.parent.TransformPoint(new Vector3(xOffset, yOffset, zOffset));
        GameObject menuInstance = Instantiate(menu, offsetMenuSpawm, menuRotation);
        menuInstance.tag = "WorldMenu";
        menuInstance.SetActive(true);
        menuInstance.transform.GetChild(0).gameObject.SetActive(true);
    }

    private void CloseExistingMenus()
    {
        Destroy(GameObject.FindWithTag("WorldMenu"));
    }
}
