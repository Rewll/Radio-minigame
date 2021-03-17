using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oranje : MonoBehaviour, IclickAble
{
    public string knopKleur { get; set; }
    public Material OranjeMat;
    public Material OranjeEmission;
    public Renderer renderer;

    private void Update()
    {
        if (GameManager.Instance.oranjeEmission)
        {
            renderer.material = OranjeEmission;
        }
        else if (!GameManager.Instance.bruinEmission)
        {
            renderer.material = OranjeMat;
        }
    }

    private void Awake()
    {
        knopKleur = "Oranje";
    }
    public void click()
    {
        GameManager.Instance.oranjeEmission = !GameManager.Instance.oranjeEmission;
        Debug.Log(gameObject + "is clicked");
    }
}