using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerCustom : MonoBehaviour
{
    public void ChangeScene(bool active)
    {
        if (active)
        {
            SceneManager.LoadScene("StylizedNatureLite_Demo");
        }
        else{
            SceneManager.LoadScene("SampleScene");
        }
    }
}

