using UnityEngine;
using UnityEngine.UI;

public class TextDeactivator : MonoBehaviour
{
    public GameObject textObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (textObject != null)
                textObject.SetActive(false);
        }
    }
}
