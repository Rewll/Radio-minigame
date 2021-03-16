using UnityEngine;

public class GameManager : SingleTon<GameManager>
{
    
    public GameObject selectionScreen;
    public enum selection
    {
        selectionScreen,
        Game1,
        Game2,
        Game3,
        Game4
    }
    public selection GameSelection;

    private void Awake()
    {
        Instance = this;
        
        selectionScreen.SetActive(false);
    }
}
