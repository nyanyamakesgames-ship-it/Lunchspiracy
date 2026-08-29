using UnityEngine;
using UnityEngine.UI;

public class PCButtonToggleOn : MonoBehaviour
{
    [SerializeField] private GameObject OnScreen;
    [SerializeField] private GameObject OffScreen;

    private void Awake()
    {
        OnScreen.SetActive(false);
        OffScreen.SetActive(true);
    }

    public void ScreenStateChange(bool ToggleValue)
    {
        if (ToggleValue)
        {
            Debug.Log("Screen is ON");
            OnScreen.SetActive(true);
            OffScreen.SetActive(false);
        }
        else
        { 
            Debug.Log("Screen is OFF");
            OnScreen.SetActive(false);
            OffScreen.SetActive(true);
        }
    }
}
