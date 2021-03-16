using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicketyClick : MonoBehaviour
{
    public void selectGame1()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game1;
    }
    public void selectGame2()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game2;
    }
    public void selectGame3()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game3;
    }
    public void selectGame4()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game4;
    }
    public void selectionScreen()
    {
        GameManager.Instance.GameSelection = GameManager.selection.selectionScreen;
    }
}
