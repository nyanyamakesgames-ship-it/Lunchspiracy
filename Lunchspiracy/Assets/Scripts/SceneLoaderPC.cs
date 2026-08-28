using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderPC : MonoBehaviour
{
    public void LoadPCViewer()
    {
        SceneManager.LoadScene("Scenes/PCView");
    }
}
