using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rechts2 : MonoBehaviour, IclickAble
{
    public Material knopR2Mat;
    public Material knopR2EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopR2 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopR2Emission)
        {
            knopRenderer.material = knopR2EmissionMat;
        }
        else if (!GameManager.Instance.knopR2Emission)
        {
            knopRenderer.material = knopR2Mat;
        }
    }
}
