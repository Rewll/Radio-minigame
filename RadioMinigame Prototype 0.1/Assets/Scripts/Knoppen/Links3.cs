using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links3 : MonoBehaviour, IclickAble
{
    public Material knopL3Mat;
    public Material knopL3EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopL3 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopL3Emission)
        {
            knopRenderer.material = knopL3EmissionMat;
        }
        else if (!GameManager.Instance.knopL3Emission)
        {
            knopRenderer.material = knopL3Mat;
        }
    }
}
