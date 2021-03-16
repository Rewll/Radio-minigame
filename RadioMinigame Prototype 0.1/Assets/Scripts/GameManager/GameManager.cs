using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTon<GameManager>
{
    Ray ray;
    RaycastHit clickHit;
    float rayLength = 100f;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonUp(0))
        {
            rayCast();
        }
        Debug.DrawRay(ray.origin, ray.direction, Color.green);
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