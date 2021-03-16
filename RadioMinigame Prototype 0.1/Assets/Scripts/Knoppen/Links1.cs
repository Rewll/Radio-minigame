using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links1 : MonoBehaviour, IclickAble
{
    public Material knopL1Mat;
    public Material knopL1EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopL1 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopL1Emission)
        {
            knopRenderer.material = knopL1EmissionMat;
        }
        else if (!GameManager.Instance.knopL1Emission)
        {
            knopRenderer.material = knopL1Mat;
        }
    }
}