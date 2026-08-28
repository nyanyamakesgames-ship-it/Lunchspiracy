using UnityEngine;
using UnityEngine.UI;

public class PCButtonToggleOn : MonoBehaviour
{
    public Image OnScreen;
    public Color OnScreenColor;
   // Call this method from the Toggle's OnValueChanged event
    public void OnToggleValueChanged(bool isOn)
    {
        OnScreen = GetComponent<Image>();


        if (isOn)
        {
           Debug.Log("toggle is on");
        }
        else
        {
            Debug.Log("toggle is off");
        }
    }
}
