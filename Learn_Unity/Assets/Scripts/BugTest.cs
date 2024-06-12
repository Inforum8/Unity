using UnityEngine;

public class MousePosition : MonoBehaviour
{
    void Update()
    {
        if (Camera.main != null)
        {
            Vector3 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(mousPos);
        }
        else
        {
            Debug.LogError("Main camera not found.");
        }
    }
}