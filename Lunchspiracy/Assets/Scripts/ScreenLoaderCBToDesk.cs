using UnityEngine;

public class ScreenLoaderCBToDesk : MonoBehaviour
{
    [SerializeField] private GameObject corkBoard;
    [SerializeField] private GameObject Desk;

    [SerializeField] private GameObject CBSelector;
    
    public void ReturnToDeskView()
    {
        corkBoard.SetActive(false);
        Desk.SetActive(true);
    }

    public void OnMouseEnter()
    {

        Debug.Log("desk selector");
    }
}
