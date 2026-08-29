using UnityEngine;

public class ScreenLoaderCB : MonoBehaviour
{
    [SerializeField] private GameObject corkBoard;

    [SerializeField] private GameObject CBSelector;
    private void Awake()
    {
        corkBoard.SetActive(false);
    }
    public void LoadCorkboardView()
    {
        corkBoard.SetActive(true);
    }

    public void OnMouseEnter()
    {

        Debug.Log("CB selector");
    }
}
