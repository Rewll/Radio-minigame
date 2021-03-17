using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geel : MonoBehaviour, IclickAble
{
    public string knopKleur { get; set ; }
    public Material geelMat;
    public Material geelEmission;
    public new Renderer renderer;

    private void Update()
    {
        if (GameManager.Instance.geelEmission)
        {
            renderer.material = geelEmission;
        }
        else if (!GameManager.Instance.geelEmission)
        {
            renderer.material = geelMat;
        }
    }

    private void Awake()
    {
        knopKleur = "Geel";
    }

    public void click()
    {
        GameManager.Instance.geelEmission = !GameManager.Instance.geelEmission;
        Debug.Log(gameObject + "is clicked");
    }
}