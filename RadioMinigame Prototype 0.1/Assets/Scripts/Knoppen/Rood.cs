using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rood : MonoBehaviour, IclickAble
{
    public string knopKleur { get; set;}
    public Material RoodMat;
    public Material RoodEmission;
    public new Renderer renderer;

    private void Update()
    {
        if (GameManager.Instance.roodEmission)
        {
            renderer.material = RoodEmission;
        }
        else if (!GameManager.Instance.roodEmission)
        {
            renderer.material = RoodMat;
        }
    }

    private void Awake()
    {
        knopKleur = "Rood";
    }

    public void click()
    {
        GameManager.Instance.roodEmission = !GameManager.Instance.roodEmission;
        Debug.Log(gameObject + "is clicked");
    }
}