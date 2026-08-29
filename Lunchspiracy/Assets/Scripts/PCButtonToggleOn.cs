using UnityEngine;
using UnityEngine.UI;

public class PCButtonToggleOn : MonoBehaviour
{
    [SerializeField] private Image OnScreen;

    private void Awake()
    {
        
    }

    public void ScreenStateChange(bool ToggleValue)
    {
        if (ToggleValue)
        {
            Debug.Log("Screen is ON");
            Color temp = OnScreen.color;
            temp.a = 1;
            OnScreen.color = temp;
        }
        else
        { 
            Debug.Log("Screen is OFF");
            Color temp = OnScreen.color;
            temp.a = 0;
            OnScreen.color = temp;
        }
    }
}
