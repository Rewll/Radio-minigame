using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1 : BaseState
{
    Ray ray;
    RaycastHit clickHit;
    float rayLength = 100f;
    

    public override void OnEnter()
    {

    }

    public override void OnUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonUp(0))
        {
            rayCast();
        }
        Debug.DrawRay(ray.origin, ray.direction, Color.green);
        if (GameManager.Instance.GameSelection == GameManager.selection.selectionScreen)
        {
            owner.SwitchState(typeof(SelectionState));
        }
    }

    public override void OnExit()
    {

    }

    void rayCast()
    {
        
        if (Physics.Raycast(ray, out clickHit, rayLength))
        {
            IclickAble click = clickHit.collider.transform.GetComponent<IclickAble>();
            if (click != null)
            {
                click.click();
            }
        }
    }
}



 