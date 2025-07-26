using UnityEngine;

public class MultiplayerCanvasManager : MonoBehaviour
{
    public GameObject selectionList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnJoiningClicked()
    {
        selectionList.SetActive(false);
    }
}
