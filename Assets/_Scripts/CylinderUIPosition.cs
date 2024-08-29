using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CylinderUIPosition : MonoBehaviour
{
    public GameObject refObject;
    private Transform refTransform;
    // Start is called before the first frame update
    void Start()
    {
        refTransform = refObject.transform;
    }

    // Update is called once per frame
    void OnEnable()
    {
        this.transform.rotation = UnityEngine.Quaternion.Euler(0, refTransform.localEulerAngles.y,0);
        this.transform.position = refTransform.localPosition;
    }
}
