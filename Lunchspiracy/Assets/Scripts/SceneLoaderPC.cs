using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderPC : MonoBehaviour
{
    [SerializeField] private GameObject computerPanel;

    [SerializeField] private GameObject PCSelector;
    private void Awake()
    {
        computerPanel.SetActive(false);
    }
    public void LoadPCViewer()
    {
        //SceneManager.LoadScene("Scenes/PCView");
        computerPanel.SetActive(true);
    }
    public void OnMouseEnter()
    {
        
        Debug.Log("PC selector");
    }
}
