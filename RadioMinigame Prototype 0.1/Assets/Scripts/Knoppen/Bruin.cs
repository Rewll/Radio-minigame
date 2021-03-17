using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruin : MonoBehaviour, IclickAble
{
    public string knopKleur { get; set; }
    public Material bruinMat;
    public Material bruinEmission;
    public new Renderer renderer;


    private void Update()
    {
        if (GameManager.Instance.bruinEmission)
        {
            renderer.material = bruinEmission;
        }
        else if (!GameManager.Instance.bruinEmission)
        {
            renderer.material = bruinMat;
        }
    }

    private void Awake()
    {
        knopKleur = "Bruin";
    }

    public void click()
    {
        GameManager.Instance.bruinEmission = !GameManager.Instance.bruinEmission;
        Debug.Log(gameObject + "is clicked");
    }
}