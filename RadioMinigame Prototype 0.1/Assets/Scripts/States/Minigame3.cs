using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame3 : BaseState
{
    public override void OnEnter()
    {

    }

    public override void OnUpdate()
    {
        if (GameManager.Instance.GameSelection == GameManager.selection.selectionScreen)
        {
            owner.SwitchState(typeof(SelectionState));
        }
    }

    public override void OnExit()
    {

    }
}
