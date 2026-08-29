using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderPC : MonoBehaviour
{
    public void LoadPCViewer(GameObject computerPanel)
    {
        //SceneManager.LoadScene("Scenes/PCView");
        computerPanel.SetActive(true);
        Debug.Log("click detected");
    }

    public void OnMouseEnter()
    {
        Debug.Log("PC selector");
    }
}
