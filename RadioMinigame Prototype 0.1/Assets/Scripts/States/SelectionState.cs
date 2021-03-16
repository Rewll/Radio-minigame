using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionState : BaseState
{
    public override void OnEnter()
    {
        GameManager.Instance.selectionScreen.SetActive(true);
    }

    public override void OnExit()
    {
        GameManager.Instance.selectionScreen.SetActive(false);
    }

    public override void OnUpdate()
    {
        switch (GameManager.Instance.GameSelection)
        {
            case GameManager.selection.Game1:
                owner.SwitchState(typeof(Minigame1));
                break;
            case GameManager.selection.Game2:
                owner.SwitchState(typeof(Minigame2));
                break;
            case GameManager.selection.Game3:
                owner.SwitchState(typeof(Minigame3));
                break;
            case GameManager.selection.Game4:
                owner.SwitchState(typeof(Minigame4));
                break;
        }
    }


}
