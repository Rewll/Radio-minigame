using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rechts1 : MonoBehaviour, IclickAble
{
    public Material knopR1Mat;
    public Material knopR1EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopR1 = true;
    }
    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopR1Emission)
        {
            knopRenderer.material = knopR1EmissionMat;
        }
        else if (!GameManager.Instance.knopR1Emission)
        {
            knopRenderer.material = knopR1Mat;
        }
    }
}