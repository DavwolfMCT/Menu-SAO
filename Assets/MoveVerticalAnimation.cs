using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticalAnimation : MonoBehaviour
{
    public float distance = -0.38f; // 20 cm
    public float duration = 2f; // 2 s
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveVerticalAnimationStart()
    {
        Debug.Log("DIALOG, Start");
        StartCoroutine(MoveVerticalCoroutine());
    }



    private IEnumerator MoveVerticalCoroutine()
    {
        RectTransform rectTransformToMove = this.gameObject.GetComponent<RectTransform>();
        Vector3 startPosition = rectTransformToMove.position;
        Debug.Log("DIALOG, Posi: " + startPosition.ToString());
        Vector3 endPosition = startPosition + new Vector3(0, distance, 0);
        Debug.Log("DIALOG, PosF: " + endPosition.ToString());
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            Debug.Log("DIALOG, PosActual: " + rectTransformToMove.position.ToString());
            rectTransformToMove.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rectTransformToMove.position = endPosition; // Asegúrate de que el RectTransform llegue exactamente al final
        Debug.Log("DIALOG, PosUltima: " + rectTransformToMove.position.ToString());
    }
}
