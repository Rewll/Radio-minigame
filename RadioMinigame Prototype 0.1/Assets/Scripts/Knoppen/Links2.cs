using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links2 : MonoBehaviour, IclickAble
{
    public Material knopL2Mat;
    public Material knopL2EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopL2 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopL2Emission)
        {
            knopRenderer.material = knopL2EmissionMat;
        }
        else if (!GameManager.Instance.knopL2Emission)
        {
            knopRenderer.material = knopL2Mat;
        }
    }
}
