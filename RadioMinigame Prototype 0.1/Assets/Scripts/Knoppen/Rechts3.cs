using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rechts3 : MonoBehaviour, IclickAble
{
    public Material knopR3Mat;
    public Material knopR3EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopR3 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopR3Emission)
        {
            knopRenderer.material = knopR3EmissionMat;
        }
        else if (!GameManager.Instance.knopR3Emission)
        {
            knopRenderer.material = knopR3Mat;
        }
    }
}
