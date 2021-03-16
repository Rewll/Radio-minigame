using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicketyClick : MonoBehaviour
{
    void selectGame1()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game1;
    }
    void selectGame2()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game2;
    }
    void selectGame3()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game3;
    }
    void selectGame4()
    {
        GameManager.Instance.GameSelection = GameManager.selection.Game4;
    }
    void selectionScreen()
    {
        GameManager.Instance.GameSelection = GameManager.selection.selectionScreen;
    }
}
